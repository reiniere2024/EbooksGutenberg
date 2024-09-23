Imports Excel
Imports System
Imports System.Reflection ' For Missing.Value and BindingFlags
Imports System.Runtime.InteropServices ' For COMException
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data.Common
Imports Microsoft.Office.Interop.Word


Public Class SearchEbooks

    Private EbookShown As Boolean = False

    Private MyYear As String
    Private ds, ds_server, ds_categorie, ds_opbrengsten, ds_totals As New DataSet

    Private CurIndex As Integer = 1
    Private CurCell As String
    Private ExcelFileName As String
    Private InitialDir As String = CurDir()

    'Private xlApp As Excel.Application
    'Private xlBooks As Excel.Workbooks
    'Private xlBook As Excel.Workbook
    'Private xlSheets As Excel.Sheets
    'Private xlSheet As Excel.Worksheet

    Private Sub frmAnalyseBoekingen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim srv, user, pwd, db, mysql, s1, type, mysqlcat, mysqlcat2 As String
        Dim mystring As String
        Dim datemp As DbDataAdapter
        Dim dstemp As New DataSet
        Dim da, da_categorie, da_opbrengsten As DbDataAdapter
        Dim myconnection1 As DbConnection
        Dim nr As Integer
        Dim DStart, DEnd As Date

        DEnd = Now()
        'DStart = CDate(DEnd.AddYears(-24))

        tbStart.Text = "1970-01-01" 'DStart.ToString("yyyy-MM-dd")
        tbEnd.Text = DEnd.ToString("yyyy-MM-dd")

        InitialDir = CurDir()
        ds_server.ReadXml(CurDir() + "\xml\server.xml")
        ds.ReadXml(CurDir() + "\xml\boekingen2.xml")
        ds.Tables(0).Rows.RemoveAt(0)

        Me.ds.Tables(0).DefaultView.AllowNew = False
        Me.ds.Tables(0).DefaultView.AllowDelete = False
        Me.DataGrid1.DataSource = Me.ds.Tables(0)
        Me.FormatColumnHeaders()


        type = ds_server.Tables(0).Rows(0).Item(0)
        srv = ds_server.Tables(0).Rows(0).Item(1)
        user = ds_server.Tables(0).Rows(0).Item(2)
        pwd = ds_server.Tables(0).Rows(0).Item(3)
        db = ds_server.Tables(0).Rows(0).Item(4)

        mystring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + db + "';Jet OLEDB:Database Password=Tapyxe01"
        myconnection1 = New OleDbConnection(mystring)
        mysql = "select category from Categories order by category"
        datemp = New OleDbDataAdapter
        datemp.SelectCommand = New OleDbCommand(mysql, myconnection1)

        myconnection1.Open()
        datemp.Fill(dstemp, "Categories")
        For i = 0 To dstemp.Tables(0).Rows.Count - 1
            s1 = dstemp.Tables(0).Rows(i).Item(0)
            cbCategorie.Items.Add(s1)
        Next

        mysqlcat = "select Shelf from Bookshelves order by Shelf"
        da_categorie = New OleDbDataAdapter
        da_categorie.SelectCommand = New OleDbCommand(mysqlcat, myconnection1)
        da_categorie.Fill(ds_categorie, "Bookshelves")
        For i = 0 To ds_categorie.Tables(0).Rows.Count - 1
            s1 = ds_categorie.Tables(0).Rows(i).Item(0)
            cbShelf.Items.Add(s1)
        Next

        Me.GetEBooks()
        Me.ShowFields()


    End Sub

    Private Sub FormatColumnHeaders()

        Dim ts As New DataGridTableStyle
        Dim cs0, cs1, cs2, cs3, cs4, cs5, cs6, cs7, cs8, cs9, cs10, cs11 As DataGridTextBoxColumn

        ts.MappingName = "EBooks"

        ' "select Textnr,BookType,Issued,BookTitle,BookLanguage,Authors,Subjects,LoCC,Bookshelves from EBooks " + mywhere + myorder

        cs0 = New DataGridTextBoxColumn
        cs0.MappingName = "Textnr"
        cs0.HeaderText = "Nr:"
        cs0.Width = 50
        ts.GridColumnStyles.Add(cs0)

        cs1 = New DataGridTextBoxColumn
        cs1.MappingName = "BookType"
        cs1.HeaderText = "Type:"
        cs1.Width = 50
        ts.GridColumnStyles.Add(cs1)

        cs2 = New DataGridTextBoxColumn
        cs2.MappingName = "Issued"
        cs2.HeaderText = "Date:"
        cs2.Width = 80
        ts.GridColumnStyles.Add(cs2)

        cs3 = New DataGridTextBoxColumn
        cs3.MappingName = "BookLanguage"
        cs3.HeaderText = "Lang:"
        cs3.Width = 50
        ts.GridColumnStyles.Add(cs3)

        cs4 = New DataGridTextBoxColumn
        cs4.MappingName = "Authors"
        cs4.HeaderText = "Author:"
        cs4.Width = 330
        ts.GridColumnStyles.Add(cs4)

        cs5 = New DataGridTextBoxColumn
        cs5.MappingName = "BookTitle"
        cs5.HeaderText = "Title:"
        cs5.Width = 360
        ts.GridColumnStyles.Add(cs5)

        'cs6 = New DataGridTextBoxColumn
        'cs6.MappingName = "type"
        'cs6.HeaderText = "Af Bij:"
        'cs6.Width = 40
        'ts.GridColumnStyles.Add(cs6)

        'cs7 = New DataGridTextBoxColumn
        'cs7.MappingName = "mutation"
        'cs7.HeaderText = "Amount:"
        'cs7.Width = 50
        'ts.GridColumnStyles.Add(cs7)

        'cs8 = New DataGridTextBoxColumn
        'cs8.MappingName = "mutationsort"
        'cs8.HeaderText = "Sort:"
        'cs8.Width = 45
        'ts.GridColumnStyles.Add(cs8)

        'cs9 = New DataGridTextBoxColumn
        'cs9.MappingName = "mededeling"
        'cs9.HeaderText = "Message:"
        'cs9.Width = 150
        'ts.GridColumnStyles.Add(cs9)


        'cs10 = New DataGridTextBoxColumn
        'cs10.MappingName = "categorie"
        'cs10.HeaderText = "Cat:"
        'cs10.Width = 30
        'ts.GridColumnStyles.Add(cs10)


        'cs11 = New DataGridTextBoxColumn
        'cs11.MappingName = "overboeking"
        'cs11.HeaderText = "ovb:"
        'cs11.Width = 0
        'ts.GridColumnStyles.Add(cs11)
        'ts.AllowSorting = False

        DataGrid1.TableStyles.Add(ts)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub


    Private Sub GetEBooks()

        Dim srv, user, pwd, db, mysql, catnum, mymonth, type, Str As String
        Dim mystring, mywhere, MyCat, catnr, myorder, myordercol As String
        Dim myconnection1 As DbConnection
        Dim da As DbDataAdapter
        Dim mycommand As DbCommand
        Dim i, j, mytotals, pos As Integer
        Dim DStart, DEnd As Date


        ds.Reset()
        ds_server.ReadXml(InitialDir + "\xml\server.xml")
        ' Open connection
        type = ds_server.Tables(0).Rows(0).Item(0)
        srv = ds_server.Tables(0).Rows(0).Item(1)
        user = ds_server.Tables(0).Rows(0).Item(2)
        pwd = ds_server.Tables(0).Rows(0).Item(3)
        db = InitialDir + "\" + ds_server.Tables(0).Rows(0).Item(4)

        'tbStart.Text = DStart.ToString("yyyy-MM-dd")
        'tbEnd.Text = DEnd.ToString("yyyy-MM-dd")

        If tbStart.Text <> "" And tbEnd.Text <> "" Then
            DStart = tbStart.Text
            DEnd = tbEnd.Text
            '1. The Date
            mywhere = "WHERE Issued >= '" + tbStart.Text + "' AND Issued <= '" + tbEnd.Text + "'"
        End If
        If cbAccount.Text <> "All" Then
            Str = cbAccount.Text
            Str = Str.Substring(0, 3)
            If Str.Substring(2, 1) = "-" Then
                Str = Str.Substring(0, 2)
            End If
            If mywhere = "" Then
                mywhere = mywhere + " Where BookLanguage = '" + Str + "'"
            Else
                mywhere = mywhere + " AND BookLanguage = '" + Str + "'"
            End If
        End If
        If cbAuthors.Text <> "" Then
            If mywhere = "" Then
                mywhere = mywhere + " Where Authors LIKE '%" + Trim(cbAuthors.Text) + "%'"
            Else
                mywhere = mywhere + " AND Authors LIKE '%" + Trim(cbAuthors.Text) + "%'"
            End If
        End If
        If cbCategorie.Text <> "" Then
            If mywhere = "" Then
                mywhere = mywhere + " Where Subjects LIKE '%" + Trim(cbCategorie.Text) + "%'"
            Else
                mywhere = mywhere + " AND Subjects LIKE '%" + Trim(cbCategorie.Text) + "%'"
            End If
        End If
        If cbShelf.Text <> "" Then
            If mywhere = "" Then
                mywhere = mywhere + " Where Bookshelves LIKE '%" + Trim(cbShelf.Text) + "%'"
            Else
                mywhere = mywhere + " AND Bookshelves LIKE '%" + Trim(cbShelf.Text) + "%'"
            End If
        End If
        If cbType.Text <> "" Then
            If mywhere = "" Then
                mywhere = mywhere + " Where BookType = '" + Trim(cbType.Text) + "'"
            Else
                mywhere = mywhere + " AND BookType = '" + Trim(cbType.Text) + "'"
            End If
        End If
        If cbLOC.Text <> "" Then
            Str = cbLOC.Text
            pos = InStr(1, Str, "-")
            If pos > 0 Then
                Str = Str.Substring(0, pos - 1)
                If mywhere = "" Then
                    mywhere = mywhere + " Where LoCC LIKE '%" + Str + "%'"
                Else
                    mywhere = mywhere + " AND LoCC LIKE '%" + Str + "%'"
                End If
            End If
        End If
        '7. Omschrijving
        If tbOmschrijving.Text <> "" Then
            If mywhere = "" Then
                mywhere = mywhere + " Where BookTitle like '%" + tbOmschrijving.Text + "%'"
            Else
                mywhere = mywhere + " AND BookTitle like '%" + tbOmschrijving.Text + "%'"
            End If
        End If

        If cbSorteren.Text <> "" Then
            myorder = " order by " + cbSorteren.Text + " " + cbDirection.Text
        End If


        Select Case type
            Case "ACCESS"
                mystring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + db + "';Jet OLEDB:Database Password=Tapyxe01"
                myconnection1 = New OleDbConnection(mystring)

                mysql = "select Textnr,BookType,Issued,BookTitle,BookLanguage,Authors,Subjects,LoCC,Bookshelves from EBooks " + mywhere + myorder
                'mysql = "select Textnr,BookType,Issued,BookTitle,BookLanguage,Authors,Subjects,LoCC,Bookshelves from EBooks "

                da = New OleDbDataAdapter
                da.SelectCommand = New OleDbCommand(mysql, myconnection1)
                mycommand = New OleDbCommand


        End Select

        Try
            myconnection1.Open()
            da.Fill(ds, "EBooks")

            Me.ds.Tables(0).DefaultView.AllowNew = False
            Me.ds.Tables(0).DefaultView.AllowDelete = False
            DataGrid1.DataSource = ds.Tables(0)
            DataGrid1.AllowSorting = False

            tbAantal.Text = ds.Tables(0).Rows.Count


        Catch ex As Exception
            MsgBox(ex.Message)
            'LogMessage(ex.Message, "Analyse Boekingen zoek transacties")

        Finally
            myconnection1.Close()

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.GetEBooks()
        Me.ShowFields()

    End Sub


    Private Function ConvertOrder(ByVal mycol As String) As String
        Dim mycolname As String = ""

        Select Case mycol
            Case "Date"
                mycolname = "transdate"
            Case "Name"
                mycolname = "transname"
            Case "Account"
                mycolname = "account2"
            Case "Code"
                mycolname = "code"
            Case "Category"
                mycolname = "categorie"
            Case "Bookingsnumber"
                mycolname = "boekingid"

        End Select
        Return mycolname

    End Function

    'Private Sub cbType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbType.SelectedIndexChanged
    '    Dim srv, user, pwd, db, mysql, s1, type As String
    '    Dim mystring As String
    '    Dim da As DbDataAdapter
    '    Dim myconnection1 As DbConnection
    '    Dim dstemp As New DataSet

    '    MyYear = Now().Year
    '    'tbStart.Text = MyYear + "0101"
    '    'tbEnd.Text = MyYear + "1231"

    '    ds_server.ReadXml(InitialDir + "\xml\server.xml")
    '    ' Open connection
    '    type = ds_server.Tables(0).Rows(0).Item(0)
    '    srv = ds_server.Tables(0).Rows(0).Item(1)
    '    user = ds_server.Tables(0).Rows(0).Item(2)
    '    pwd = ds_server.Tables(0).Rows(0).Item(3)
    '    db = InitialDir + "\" + ds_server.Tables(0).Rows(0).Item(4)

    '    cbCategorie.Items.Clear()

    '    Select Case type
    '        Case "ACCESS"
    '            mystring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + db + "';Jet OLEDB:Database Password=Tapyxe01"
    '            myconnection1 = New OleDbConnection(mystring)
    '            If cbType.Text = "Af" Then
    '                mysql = "select str(catid) + ',' + catname from Kosten order by catid"
    '            Else
    '                mysql = "select str(catid) + ',' + catname from Opbrengsten order by catid"
    '            End If
    '            da = New OleDbDataAdapter
    '            da.SelectCommand = New OleDbCommand(mysql, myconnection1)

    '    End Select

    '    Try
    '        myconnection1.Open()
    '        'vullen combobox categorie
    '        If cbType.Text = "Af" Then
    '            da.Fill(dstemp, "Kosten")
    '        Else
    '            da.Fill(dstemp, "Opbrengsten")
    '        End If
    '        For i = 0 To dstemp.Tables(0).Rows.Count - 1
    '            s1 = dstemp.Tables(0).Rows(i).Item(0)
    '            cbCategorie.Items.Add(s1)
    '        Next

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        'LogMessage(ex.Message, "Analyse Boekingen select categorien")

    '    Finally
    '        myconnection1.Close()

    '    End Try


    'End Sub



    Private Sub DataGrid1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.Click
        'Dim rowid As Integer
        'Dim text As String

        'rowid = DataGrid1.CurrentRowIndex
        'If rowid >= 0 Then
        '    text = ds.Tables(0).Rows(rowid).Item(9)
        '    tbTekst.Text = text

        'End If


    End Sub


    Private Sub ShowFields()

        Dim rowid As Integer
        Dim str, str2, str3 As String

        Try
            rowid = DataGrid1.CurrentRowIndex
            str = ds.Tables(0).Rows(rowid).Item(3).ToString()
            str2 = ds.Tables(0).Rows(rowid).Item(6).ToString()
            str3 = ds.Tables(0).Rows(rowid).Item(7).ToString()

            tbTekst.Text = str
            tbCategory.Text = str2
            tbLocc.Text = str3

        Catch ex As Exception

        End Try


    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged

        Me.ShowFields()

    End Sub




    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim strDat As Object
        'Dim xlRange As Excel.Range
        'Dim strRange As String
        'Dim i As Integer
        'Dim filnam As String = InitialDir + "Excel\Template.xls"
        'Dim sDatum, sNaam, sRekening, sTegenrekening, sCode, sAfBij, sBedrag, sSoort, sMededeling, sCategory, sCategoryName, sOverboeking As String
        'Dim currow As Integer
        'Dim xlApp As Excel.Application
        'Dim xlBooks As Excel.Workbooks
        'Dim xlBook As Excel.Workbook
        'Dim xlSheets As Excel.Sheets
        'Dim xlSheet As Excel.Worksheet

        'If xlSheet Is Nothing Then
        '    'Get the excel File
        '    OpenFileDialog1.InitialDirectory = InitialDir + "\Excel"
        '    If OpenFileDialog1.ShowDialog() <> 1 Then
        '        Return
        '    End If
        '    ExcelFileName = OpenFileDialog1.FileName
        '    xlApp = New Excel.Application

        '    'Dim newCulture As System.Globalization.CultureInfo
        '    'Dim OldCulture As System.Globalization.CultureInfo
        '    'OldCulture = System.Threading.Thread.CurrentThread.CurrentCulture
        '    'newCulture = New System.Globalization.CultureInfo(xlApp.LanguageSettings.LanguageID(Microsoft.Office.Core.MsoAppLanguageID.msoLanguageIDUI))
        '    'newCulture = New System.Globalization.CultureInfo(xlApp.LanguageSettings.LanguageID(
        '    'System.Threading.Thread.CurrentThread.CurrentCulture = newCulture

        '    xlBooks = xlApp.Workbooks
        '    xlBook = xlBooks.Open(ExcelFileName)
        '    xlSheets = xlBook.Worksheets
        '    xlSheet = xlSheets.Item(1)
        '    xlApp.Visible = True
        'Else
        '    'xlSheet.Application.Visible = False
        '    'xlSheet.Application.Visible = True
        '    'xlSheet.Activate()
        'End If
        'CurCell = "A2"
        'For currow = 0 To ds.Tables(0).Rows.Count - 1
        '    sDatum = ds.Tables(0).Rows(currow).Item(1)
        '    sNaam = ds.Tables(0).Rows(currow).Item(2)
        '    sRekening = ds.Tables(0).Rows(currow).Item(3)
        '    sTegenrekening = ds.Tables(0).Rows(currow).Item(4)
        '    sCode = ds.Tables(0).Rows(currow).Item(5)
        '    sAfBij = ds.Tables(0).Rows(currow).Item(6)
        '    sBedrag = ds.Tables(0).Rows(currow).Item(7)
        '    sSoort = ds.Tables(0).Rows(currow).Item(8)
        '    sMededeling = ds.Tables(0).Rows(currow).Item(9)
        '    sCategory = ds.Tables(0).Rows(currow).Item(10)
        '    sOverboeking = ds.Tables(0).Rows(currow).Item(11)
        '    'date
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sDatum
        '    Me.AdjustCell()
        '    'name
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sNaam
        '    Me.AdjustCell()
        '    'account
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sRekening
        '    Me.AdjustCell()
        '    'account2
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sTegenrekening
        '    Me.AdjustCell()
        '    'code
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sCode
        '    Me.AdjustCell()
        '    'af bij
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sAfBij
        '    Me.AdjustCell()
        '    'amount
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sBedrag
        '    Me.AdjustCell()
        '    'mutationsort
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sSoort
        '    Me.AdjustCell()
        '    'text
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sMededeling
        '    Me.AdjustCell()
        '    'categorie
        '    If cbType.Text = "Af" Then
        '        sCategoryName = Me.GetCategory(sCategory)
        '    Else 'Bij
        '        sCategoryName = Me.GetCategory2(sCategory)
        '    End If
        '    xlRange = xlSheet.Range(CurCell)
        '    xlRange.Value = sCategoryName
        '    Me.AdjustCell()

        'Next



    End Sub
    Private Function GetCategory2(ByVal catnum As String) As String
        Dim catname As String = ""

        'Dim s As Integer = 1
        'Dim foundRow As DataRow = ds_categorie.Tables(0).Rows.Find(s)

        Dim foundRows() As Data.DataRow
        foundRows = ds_opbrengsten.Tables(0).Select("catid = " + catnum)

        If foundRows IsNot Nothing Then
            'MsgBox(foundRows(0).ToString())
            Return foundRows(0).Item(1).ToString()

        Else
            Return ""
        End If

    End Function
    Private Function GetCategory(ByVal catnum As String) As String
        Dim catname As String = ""

        'Dim s As Integer = 1
        'Dim foundRow As DataRow = ds_categorie.Tables(0).Rows.Find(s)

        Dim foundRows() As Data.DataRow
        foundRows = ds_categorie.Tables(0).Select("catid = " + catnum)

        If foundRows IsNot Nothing Then
            'MsgBox(foundRows(0).ToString())
            Return foundRows(0).Item(1).ToString()

        Else
            Return ""
        End If

    End Function

    Private Function GetCategoryDB(ByVal catnum As String) As String
        Dim catname As String = ""
        Dim my_sql As String
        Dim srv, user, pwd, db, type As String
        Dim mystring As String
        Dim i As Integer
        Dim myconnection1 As DbConnection
        Dim mycommand As DbCommand

        ds_server.ReadXml(InitialDir + "\xml\server.xml")
        ' Open connection
        type = ds_server.Tables(0).Rows(0).Item(0)
        srv = ds_server.Tables(0).Rows(0).Item(1)
        user = ds_server.Tables(0).Rows(0).Item(2)
        pwd = ds_server.Tables(0).Rows(0).Item(3)
        db = InitialDir + "\" + ds_server.Tables(0).Rows(0).Item(4)

        Select Case type
            Case "ACCESS"
                mystring = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + db + "';Jet OLEDB:Database Password=Tapyxe01"
                myconnection1 = New OleDbConnection(mystring)
                mycommand = New OleDbCommand

            Case "MSS"
                mystring = "Data source=" + srv + ";user id=" + user + ";password=" + pwd + ";initial catalog=" + db + ";"
                myconnection1 = New SqlConnection(mystring)
                mycommand = New SqlCommand
            Case "ORA"
                mystring = "Provider=OraOLEDB.Oracle;User ID=" + user + ";Password=" + pwd + ";Data source=" + srv + ";FetchSize=1024;"
                myconnection1 = New OleDbConnection(mystring)
                mycommand = New OleDbCommand

        End Select

        Try
            myconnection1.Open()
            mycommand.Connection = myconnection1
            my_sql = "select catname from kosten where catid = " + catnum
            mycommand.CommandText = my_sql
            catname = mycommand.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)
            'LogMessage(ex.Message, "Analyse Boekingen Select Category Name")
            Return ""

        Finally
            myconnection1.Close()

        End Try

        Return catname


    End Function
    Private Sub AdjustCell()
        Dim i As Integer
        Dim cell, newcell As String

        cell = Mid(CurCell, 1, 1)
        newcell = cell
        i = CInt(Mid(CurCell, 2, Len(CurCell) - 1))

        Select Case cell
            Case "A"
                newcell = "B"
            Case "B"
                newcell = "C"
            Case "C"
                newcell = "D"
            Case "D"
                newcell = "E"
            Case "E"
                newcell = "F"
            Case "F"
                newcell = "G"
            Case "G"
                newcell = "H"
            Case "H"
                newcell = "I"
            Case "I"
                newcell = "J"
            Case "J"
                newcell = "A"
                i = i + 1
        End Select

        CurCell = newcell + i.ToString()

    End Sub


    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWeb.Click
        Dim myurl, text As String
        Dim rowid, textnr As Integer
        Dim str, str2, str3 As String

        Try
            If EbookShown = False Then

                rowid = DataGrid1.CurrentRowIndex
                textnr = ds.Tables(0).Rows(rowid).Item(0).ToString()

                myurl = "https://gutenberg.org/ebooks/" + textnr.ToString()

                WebBrowser1.ScriptErrorsSuppressed = True
                WebBrowser1.Url = New System.Uri(myurl)

                btnWeb.Text = "Close EBook"
                WebBrowser1.Visible = True
                EbookShown = True
            Else

                btnWeb.Text = "Get EBook"
                WebBrowser1.Visible = False
                EbookShown = False

            End If

        Catch ex As Exception

            MsgBox("Choose a book first !")

        End Try



    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim myurl, text As String
        Dim rowid, textnr As Integer
        Dim str, str2, str3 As String

        rowid = DataGrid1.CurrentRowIndex
        textnr = ds.Tables(0).Rows(rowid).Item(0).ToString()

        'myurl = "https://gutenberg.org/ebooks/" + textnr.ToString()

        myurl = "https://gutenberg.org/cache/epub/63963/pg63963.txt"


        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Url = New System.Uri(myurl)
        WebBrowser1.Visible = True



    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim myurl, text As String
        Dim rowid, textnr As Integer
        Dim str, str2, str3 As String

        rowid = DataGrid1.CurrentRowIndex
        textnr = ds.Tables(0).Rows(rowid).Item(0).ToString()

        'myurl = "https://gutenberg.org/ebooks/" + textnr.ToString()

        myurl = "https://gutenberg.org/cache/epub/63963/pg63963-images.html"


        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Url = New System.Uri(myurl)
        WebBrowser1.Visible = True


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim myurl, text As String
        Dim rowid, textnr As Integer
        Dim str, str2, str3 As String

        rowid = DataGrid1.CurrentRowIndex
        textnr = ds.Tables(0).Rows(rowid).Item(0).ToString()

        'myurl = "https://gutenberg.org/ebooks/" + textnr.ToString()

        myurl = "https://gutenberg.org/ebooks/63963.epub.noimages"


        WebBrowser1.ScriptErrorsSuppressed = True
        WebBrowser1.Url = New System.Uri(myurl)
        WebBrowser1.Visible = True

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        WebBrowser1.GoBack()

    End Sub
End Class