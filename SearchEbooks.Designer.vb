<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchEbooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchEbooks))
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.tbStart = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbEnd = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbAuthors = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbCategorie = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbOmschrijving = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.cbAccount = New System.Windows.Forms.ComboBox
        Me.lblTooltip = New System.Windows.Forms.Label
        Me.tbTekst = New System.Windows.Forms.TextBox
        Me.tbAantal = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cbSorteren = New System.Windows.Forms.ComboBox
        Me.cbDirection = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbShelf = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbType = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cbLOC = New System.Windows.Forms.ComboBox
        Me.tbCategory = New System.Windows.Forms.TextBox
        Me.tbLocc = New System.Windows.Forms.TextBox
        Me.btnWeb = New System.Windows.Forms.Button
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Button8 = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(12, 93)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.PreferredColumnWidth = 50
        Me.DataGrid1.Size = New System.Drawing.Size(979, 486)
        Me.DataGrid1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(920, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "&Search"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbStart
        '
        Me.tbStart.Location = New System.Drawing.Point(421, 64)
        Me.tbStart.Name = "tbStart"
        Me.tbStart.Size = New System.Drawing.Size(64, 20)
        Me.tbStart.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Start:"
        '
        'tbEnd
        '
        Me.tbEnd.Location = New System.Drawing.Point(562, 64)
        Me.tbEnd.Name = "tbEnd"
        Me.tbEnd.Size = New System.Drawing.Size(64, 20)
        Me.tbEnd.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "End:"
        '
        'cbAuthors
        '
        Me.cbAuthors.FormattingEnabled = True
        Me.cbAuthors.Items.AddRange(New Object() {"Aeschylus", "Aesop", "Agricola", "Agrippa", "Alphen, Hieronymus van, 1746-1803", "American Academy of Political and Social Science", "American and Foreign Anti-Slavery Society", "American Anti-Slavery Society", "American Art Association", "American Book Company", "American Bureau of Engineering, Chicago", "American Consolidated Mines Company", "American Institute of Child Life", "American Jewish Committee", "American National Red Cross", "American Oil Company", "American Railway Association", "American Society of Civil Engineers", "Amundsen, Roald, 1872-1928", "Andersen, H. C. (Hans Christian), 1805-1875", "Anderson, Paul, 1880-1956", "Anonymous", "Apollinaire, Guillaume, 1880-1918", "Aristophanes,", "Asimov, Isaac, 1920-1992", "Austen, Jane, 1775-1817", "Australia. Department of External Affairs", "Australia. Queensland. Department of Ports and Harbours", "Avery, Harold, 1867-1943", "Babbage, Charles, 1791-1871", "Bacon, Francis, 1561-1626", "Bailey, Arthur Scott, 1877-1949", "Bakunin, Mikhail Aleksandrovich, 1814-1876", "Balzac, Honoré de, 1799-1850", "Baudelaire, Charles, 1821-1867", "Beethoven, Ludwig van, 1770-1827", "Bell, Joseph, 1837-1911", "Bellamy, Edward, 1850-1898", "Bergson, Henri, 1859-1941;", "Berlioz, Hector, 1803-1869", "Bilderdijk, Willem, 1756-1831", "Stevenson, Robert Louis, 1850-1894", "Blish, James, 1921-1975;", "Bonaparte, Pierre Napoléon, prince, 1815-1881", "Bontekoe, Willem Ysbrantsz., 1587-1647?; Hoogewerff, G. J. (Godefridus Joannes), " & _
                        "1884- [Editor]", "Bosboom-Toussaint, A. L. G. (Anna Louisa Geertruida), 1812-1886", "Bova, Ben, 1932-2020;", "Bradbury, Ray, 1920-2012", "British Museum (Natural History)", "British Museum. Department of Coins and Medals;", "British Museum. Department of Greek and Roman Antiquities", "British Museum. Department of Manuscripts;", "Brontë, Anne, 1820-1849", "Brontë, Charlotte, 1816-1855", "Brontë, Emily, 1818-1848", "Brown, Fredric, 1906-1972", "Buchholtz, Johannes, 1882-1940;", "Bunyan, John, 1628-1688", "Burroughs, Edgar Rice, 1875-1950", "Busken Huet, Conrad, 1826-1886", "Byron, George Gordon Byron, Baron, 1788-1824", "California State Automobile Association", "California. Alaska-Yukon-Pacific exposition commission;", "California. State Board of Charities and Corrections", "Canada", "Canada. National Parks Branch", "Canada. Post Office Department", "Canadian War Records Office; ", "Carlyle, Thomas, 1795-1881", "Carroll, Lewis, 1832-1898", "Casanova, Giacomo, 1725-1798;", "Cervantes Saavedra, Miguel de, 1547-1616; ", "Chaucer, Geoffrey, 1343?-1400", "Chekhov, Anton Pavlovich, 1860-1904", "Chesterton, G. K. (Gilbert Keith), 1874-1936", "Chopin, Frédéric, 1810-1849", "Christie, Agatha, 1890-1976", "Churchill, Winston, 1871-1947", "Cicero, Marcus Tullius, 107 BCE-44 BCE", "Clausewitz, Carl von, 1780-1831", "Clement, Hal, 1922-2003; ", "Clinton, Bill, 1946-", "Coleridge, Samuel Taylor, 1772-1834", "Comte, Auguste, 1798-1857", "Confucius, 552 BCE-480 BCE;", "Conrad, Joseph, 1857-1924", "Couperus, Louis, 1863-1923", "Cummings, Ray, 1887-1957", "Curie, Marie, 1867-1934", "Cyrano de Bergerac, 1619-1655;", "Dante Alighieri, 1265-1321;", "Darwin, Charles, 1809-1882", "Dedekind, Richard, 1831-1916; Beman, Wooster Woodruff, 1850-1922 [Translator]", "Defoe, Daniel, 1661?-1731", "Deken, Agatha, 1741-1804; Wolff, Elizabeth Bekker, 1738-1804", "Del Rey, Lester, 1915-1993", "Delany, Samuel R., 1942-", "Descartes, René, 1596-1650", "Deyssel, Lodewijk van, 1864-1952", "Dick, Philip K., 1928-1982", "Dickens, Charles, 1812-1870", "Dickinson, Emily, 1830-1886", "Diderot, Denis, 1713-1784", "Disch, Thomas M., 1940-2008", "Donne, John, 1572-1631", "Doré, Gustave, 1832-1883", "Dostoyevsky, Fyodor, 1821-1881", "Doyle, Arthur Conan, 1859-1930", "Dryden, John, 1631-1700", "Dumas, Alexandre, 1802-1870", "Eeden, Frederik van, 1860-1932", "Einstein, Albert, 1879-1955", "Eliot, T. S. (Thomas Stearns), 1888-1965", "Engels, Friedrich, 1820-1895", "Erasmus, Desiderius, 1469-1536", "Euripides, 481? BCE-407 BCE;", "Farmer, Philip José, 1918-2009", "Fitzgerald, F. Scott (Francis Scott), 1896-1940", "Flaubert, Gustave, 1821-1880", "Fletcher, J. S. (Joseph Smith), 1863-1935", "Fontenay, Charles L., 1917-2007", "Ford Motor Company", "Ford, Gerald R., 1913-2006", "Forster, E. M. (Edward Morgan), 1879-1970", "France, Anatole, 1844-1924", "Franklin, Benjamin, 1706-1790", "Frege, Gottlob, 1848-1925", "Freud, Sigmund, 1856-1939", "Fyfe, H. B. (Horace Bowne), 1918-1997", "Galouye, Daniel F., 1920-1976", "Gandhi, Mahatma, 1869-1948", "Garibaldi, Giuseppe, 1807-1882", "Garrett, Randall, 1927-1987", "Gauguin, Paul, 1848-1903", "Geological Survey (U.S.)", "Gibran, Kahlil, 1883-1931", "Goethe, Johann Wolfgang von, 1749-1832", "Gogol, Nikolai Vasilevich, 1809-1852", "Goldfrap, John Henry, 1879-1917", "Gorky, Maksim, 1868-1936", "Goya, Francisco, 1746-1828", "Gray, Thomas, 1716-1771", "Great Britain", "Great Britain. Army.", "Great Britain. Board of Trade", "Great Britain. Parliament", "Great Britain. War Office", "Grimm, Jacob, 1785-1863", "Grimm, Wilhelm, 1786-1859", "Haeckel, Ernst, 1834-1919", "Hamilton, Edmond, 1904-1977", "Handel, George Frideric, 1685-1759", "Hardy, Thomas, 1840-1928", "Harness, Charles L., 1915-2005", "Harrison, Harry, 1925-2012", "Hawaii. Department of Foreign Affairs", "Hawthorne, Julian, 1846-1934", "Haydn, Joseph, 1732-1809", "Hearn, Lafcadio, 1850-1904", "Hedrick, U. P., 1870-1951", "Hegel, Georg Wilhelm Friedrich, 1770-1831", "Heijermans, Herman, 1864-1924", "Heine, Heinrich, 1797-1856", "Henry, O., 1862-1910", "Henty, G. A. (George Alfred), 1832-1902", "Herbert, Frank, 1920-1986", "Herodotus, 481? BCE-421? BCE", "Hesse, Hermann, 1877-1962", "Heyse, Paul, 1830-1914", "Hichens, Robert, 1864-1950", "Hildebrand, 1814-1903", "Hippocrates, 461? BCE-371? BCE", "Hippolytus, Antipope, 170?-236?", "Hoare, Edward, 1812-1894", "Hobart, George V. (George Vere), 1867-1926", "Hocking, Joseph, 1860-1937", "Hoffmann, E. T. A. (Ernst Theodor Amadeus), 1776-1822", "Holberg, Ludvig, 1684-1754", "Holden, Fox B., 1923-", "Holland, Clive, 1866-1959", "Homer, 751? BCE-651? BCE;", "Horace, 66 BCE-9 BCE", "Hornung, E. W. (Ernest William), 1866-1921", "Hugo, Victor, 1802-1885", "Human Genome Project", "Hume, David, 1711-1776", "Huxley, Aldous, 1894-1963", "Huysmans, J.-K. (Joris-Karl), 1848-1907", "Ibsen, Henrik, 1828-1906", "Jacobi, Carl, 1908-1997", "Jacobs, Aletta H. (Aletta Henriette), 1854-1929", "Johnston, Annie F. (Annie Fellows), 1863-1931", "Joyce, James, 1882-1941", "Jung, C. G. (Carl Gustav), 1875-1961", "Kafka, Franz, 1883-1924", "Kandinsky, Wassily, 1866-1944", "Kant, Immanuel, 1724-1804", "Keats, John, 1795-1821", "Kellogg Company", "Kennedy, John F. ", "Kieviet, Cornelis Johannes, 1858-1931", "Kingston, William Henry Giles, 1814-1880", "Kipling, Rudyard, 1865-1936", "Klein, Felix, 1849-1925", "Knight, Damon, 1922-2002; ", "Kock, Paul de, 1793-1871", "Kornbluth, C. M. (Cyril M.), 1923-1958", "Krueger, William G.", "Kummer, Frederic Arnold, 1873-1943", "Kuttner, Henry, 1915-1958", "La Fontaine, Jean de, 1621-1695", "Lafferty, R. A., 1914-2002", "Lagerlöf, Selma, 1858-1940", "Lamb, Charles, 1775-1834", "Lang, Allen Kim, 1928-", "Lang, Andrew, 1844-1912", "Laumer, Keith, 1925-1993", "Lawrence, D. H. (David Herbert), 1885-1930", "Leeuwenhoek, Antoni van, 1632-1723", "Leiber, Fritz, 1910-1992", "Leibniz, Gottfried Wilhelm, Freiherr von, 1646-1716", "Leinster, Murray, 1896-1975", "Lessing, Gotthold Ephraim, 1729-1781", "Lincoln, Abraham, 1809-1865", "Liszt, Franz, 1811-1886", "Livingstone, David, 1813-1873", "Locke, William John, 1863-1930", "London, Jack, 1876-1916", "Longfellow, Henry Wadsworth, 1807-1882", "Lorentz, H. A. (Hendrik Antoon), 1853-1928", "Lovecraft, H. P. (Howard Phillips), 1890-1937", "Luther, Martin, 1483-1546", "Machiavelli, Niccolò, 1469-1527", "Malory, Thomas, Sir, -1471", "Malot, Hector, 1830-1907", "Mann, Thomas, 1875-1955", "Marks, Winston K. (Winston Kinney), 1915-1979", "Marlowe, Christopher, 1564-1593", "Marx, Karl, 1818-1883", "Mason, David, 1924-1974", "Maugham, W. Somerset (William Somerset), 1874-1965", "Maupassant, Guy de, 1850-1893", "May, Karl, 1842-1912", "Melville, Herman, 1819-1891", "Mendel, Gregor, 1822-1884", "Mendelssohn-Bartholdy, Felix, 1809-1847", "Merwin, Sam, 1910-1996", "Michelangelo Buonarroti, 1475-1564", "Mill, John Stuart, 1806-1873", "Milton, John, 1608-1674", "Molesworth, Mrs., 1839-1921", "Molière, 1622-1673", "Montesquieu, Charles de Secondat, baron de, 1689-1755", "Montgomery, Florence, 1843-1923", "Morgenstern, Christian, 1871-1914", "Morley, Christopher, 1890-1957", "Mozart, Wolfgang Amadeus, 1756-1791", "Muhammad, Prophet, -632", "Mullen, Stanley, 1911-1974", "Multatuli, 1820-1887", "Napoleon I, Emperor of the French, 1769-1821", "Napoleon III, Emperor of the French, 1808-1873", "Nescio, 1881-1961", "Newton, Isaac, 1642-1727", "Nietzsche, Friedrich Wilhelm, 1844-1900", "Nightingale, Florence, 1820-1910", "North, Grace May, 1876-1960", "Norton, Andre, 1912-2005", "Nostradamus, 1503-1566", "Novalis, 1772-1801", "Noyes, Alfred, 1880-1958", "Numers, Gustaf von, 1848-1913", "Oppenheim, E. Phillips (Edward Phillips), 1866-1946", "Orzeszkowa, Eliza, 1842-1910", "Osbourne, Lloyd, 1868-1947", "Osler, Edward, 1798-1863", "Otis, James, 1848-1912", "Owen, Wilfred, 1893-1918", "Oxford University Press", "Paine, Albert Bigelow, 1861-1937", "Perrault, Charles, 1628-1703", "Petrarca, Francesco, 1304-1374", "Piper, H. Beam, 1904-1964", "Planck, Max, 1858-1947", "Plato, 428? BCE-348? BCE", "Plutarch, 46-120?", "Poe, Edgar Allan, 1809-1849", "Pohl, Frederik, 1919-2013", "Poincaré, Henri, 1854-1912", "Pope, Alexander, 1688-1744", "Potgieter, E. J. (Everhardus Johannes), 1808-1875", "Potter, Beatrix, 1866-1943", "Pound, Ezra, 1885-1972", "Proulx, Annie, 1935-", "Proust, Marcel, 1871-1922", "Pushkin, Aleksandr Sergeevich, 1799-1837", "Queensland", "Querido, Is. (Israël), 1874-1932", "Rabelais, François, 1490?-1553?", "Rachmaninoff, Sergei, 1873-1943 [Performer]", "Racine, Jean, 1639-1699", "Raine, William MacLeod, 1871-1954", "Raleigh, Walter, 1552?-1618", "Reagan, Ronald, 1911-2004", "Reid, Mayne, 1818-1883", "Reynolds, Mack, 1917-1983", "Rilke, Rainer Maria, 1875-1926", "Rimsky-Korsakov, Nikolay, 1844-1908", "Robespierre, Maximilien, 1758-1794", "Roland Holst-Van der Schalk, Henriette, 1869-1952", "Rolland, Romain, 1866-1944", "Roosevelt, Eleanor, 1884-1962", "Roosevelt, Franklin D. (Franklin Delano), 1882-1945", "Rossetti, Christina Georgina, 1830-1894", "Rousseau, Jean-Jacques, 1712-1778", "Runeberg, Johan Ludvig, 1804-1877", "Russell, Bertrand, 1872-1970", "Rutherford, Ernest, 1871-1937", "Sabatini, Rafael, 1875-1950", "Sade, marquis de, 1740-1814", "Saint-Saëns, Camille, 1835-1921", "Schiller, Friedrich, 1759-1805", "Schlegel, Friedrich von, 1772-1829", "Schopenhauer, Arthur, 1788-1860", "Schumann, Robert, 1810-1856", "Schweitzer, Albert, 1875-1965", "Scott, Walter, 1771-1832", "Seawell, Molly Elliot, 1860-1916", "Selous, Edmund, 1857-1934", "Seneca, Lucius Annaeus, 5? BCE-65", "Seton, Ernest Thompson, 1860-1946", "Shaara, Michael, 1929?-1988", "Shakespeare, William, 1564-1616", "Shaw, Bernard, 1856-1950", "Sheckley, Robert, 1928-2005", "Shelley, Mary Wollstonecraft, 1797-1851", "Shelley, Percy Bysshe, 1792-1822", "Siebe, Josephine, 1870-1941", "Sienkiewicz, Henryk, 1846-1916", "Silverberg, Robert, 1935-", "Simak, Clifford D., 1904-1988", "Sinclair, Bertrand W., 1881-1972", "Slesar, Henry, 1927-2002", "Smedley, Frank E. (Frank Edward), 1818-1864", "Smith, E. E. (Edward Elmer), 1890-1965", "Smith, Evelyn E., 1922-2000", "Smith, George O. (George Oliver), 1911-1981", "Society for Promoting Christian Knowledge (Great Britain)", "Sophocles, 496? BCE-407 BCE", "Spearman, Frank H. (Frank Hamilton), 1859-1937", "Spence, Lewis, 1874-1955", "Spielhagen, Friedrich, 1829-1911", "Spinoza, Benedictus de, 1632-1677", "Spyri, Johanna, 1827-1901", "Stables, Gordon, 1840-1910", "Steel, Flora Annie Webster, 1847-1929", "Steiner, Rudolf, 1861-1925", "Stendhal, 1783-1842", "Stevenson, Robert Louis, 1850-1894", "Stoddard, William O., 1835-1925", "Stoker, Bram, 1847-1912", "Stooke, Eleanora H.", "Storm, Theodor, 1817-1888", "Stowe, Harriet Beecher, 1811-1896", "Strang, Herbert", "Stratemeyer, Edward, 1862-1930", "Stratton-Porter, Gene, 1863-1924", "Streuvels, Stijn, 1871-1969", "Strindberg, August, 1849-1912", "Sturgeon, Theodore, 1918-1985", "Sudermann, Hermann, 1857-1928", "Sue, Eugène, 1804-1857", "Suttner, Bertha von, 1843-1914", "Swift, Jonathan, 1667-1745", "Tacitus, Cornelius, 56-117", "Taggart, Marion Ames, 1866-1945", "Tagore, Rabindranath, 1861-1941", "Tarkington, Booth, 1869-1946", "Teasdale, Sara, 1884-1933", "Tenn, William, 1920-2010", "Tennyson, Alfred Tennyson, Baron, 1809-1892", "Thackeray, William Makepeace, 1811-1863", "Thijsse, Jac. P. (Jacobus Pieter), 1865-1945", "Thomas, à Kempis, 1380-1471", "Tieck, Ludwig, 1773-1853", "Tolstoy, Leo, graf, 1828-1910", "Topelius, Zacharias, 1818-1898", "Trakl, Georg, 1887-1914", "Turgenev, Ivan Sergeevich, 1818-1883", "Twain, Mark, 1835-1910", "Vaizey, George de Horne, Mrs., 1857-1917", "Vance, Jack, 1916-2013;", "Verlaine, Paul, 1844-1896", "Verne, Jules, 1828-1905", "Voltaire, 1694-1778", "Vondel, Joost van den, 1587-1679", "Vonnegut, Kurt, 1922-2007", "Vries, Hugo de, 1848-1935", "Wagner, Richard, 1813-1883", "Wallace, F. L. (Floyd L.), 1915-2004", "Walpole, Horace, 1717-1797", "Walther, von der Vogelweide, 1170?-1230?", "Walton, Bryce, 1918-1988", "Warner, Anne, 1869-1913", "Washington, George, 1732-1799", "Watanna, Onoto, 1875-1954", "Waterloo, Stanley, 1846-1913", "Wells, Carolyn, 1862-1942", "Whyte-Melville, G. J. (George John), 1821-1878", "Wilde, Oscar, 1854-1900", "Winterbotham, R. R. (Russell Robert), 1904-1971", "Wundt, Wilhelm Max, 1832-1920", "Yeats, W. B. (William Butler), 1865-1939", "Zola, Émile, 1840-1902", "Zweig, Stefan, 1881-1942"})
        Me.cbAuthors.Location = New System.Drawing.Point(103, 8)
        Me.cbAuthors.Name = "cbAuthors"
        Me.cbAuthors.Size = New System.Drawing.Size(231, 21)
        Me.cbAuthors.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Authors:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Category:"
        '
        'cbCategorie
        '
        Me.cbCategorie.FormattingEnabled = True
        Me.cbCategorie.Location = New System.Drawing.Point(103, 35)
        Me.cbCategorie.Name = "cbCategorie"
        Me.cbCategorie.Size = New System.Drawing.Size(231, 21)
        Me.cbCategorie.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Text:"
        '
        'tbOmschrijving
        '
        Me.tbOmschrijving.Location = New System.Drawing.Point(103, 64)
        Me.tbOmschrijving.Name = "tbOmschrijving"
        Me.tbOmschrijving.Size = New System.Drawing.Size(231, 20)
        Me.tbOmschrijving.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(959, 637)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 32
        Me.Button2.Tag = "close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(367, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Language:"
        '
        'cbAccount
        '
        Me.cbAccount.FormattingEnabled = True
        Me.cbAccount.Items.AddRange(New Object() {"All", "af-African", "ar-Arabic", "arp-Arapaho", "bg-Bulgarian", "bo-Bodo", "br-Breton", "ca-Catalan", "ceb-Cebuano", "cs-Czech", "cy-Welsh", "da-Danish", "de-German", "el-Greek", "en-English", "enm-Middle English", "eo-Esperanto", "es-Spain", "et-Estisch", "fa-Persian", "fi-Finnish", "fr-French", "fur-Friulian", "fy-Frysk", "ga-Iriash", "gl-Galician", "gla-Gaelic", "he-Hebrew", "hu-Hungarian", "ia-Interlingua", "ilo-IIioko", "is-Icelandic", "it-Italian", "iu-Inuktitut", "ja-Japanese", "la-Latin", "lt-Lithuanian", "mi-Maori", "myn-Mayan", "nah-Nahuatl", "nap-Napolitan", "nl-Dutch", "no-Norwegian", "oc-Occitan", "oji-Ojibwa", "pl-Polish", "pt-Portuguese", "rmr-Calo", "ro-Romanian", "ru-Russian", "sa-Sanskrit", "sl-Slovenian", "sr-Servian", "sv-Swedish", "te-Telugu", "tl-Tagalog", "yi-Yiddisch", "zh-Chinese"})
        Me.cbAccount.Location = New System.Drawing.Point(469, 8)
        Me.cbAccount.Name = "cbAccount"
        Me.cbAccount.Size = New System.Drawing.Size(157, 21)
        Me.cbAccount.TabIndex = 37
        Me.cbAccount.Text = "All"
        '
        'lblTooltip
        '
        Me.lblTooltip.AutoSize = True
        Me.lblTooltip.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblTooltip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTooltip.Location = New System.Drawing.Point(460, 510)
        Me.lblTooltip.Name = "lblTooltip"
        Me.lblTooltip.Size = New System.Drawing.Size(15, 15)
        Me.lblTooltip.TabIndex = 38
        Me.lblTooltip.Text = "a"
        Me.lblTooltip.Visible = False
        '
        'tbTekst
        '
        Me.tbTekst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbTekst.Location = New System.Drawing.Point(13, 613)
        Me.tbTekst.Name = "tbTekst"
        Me.tbTekst.Size = New System.Drawing.Size(978, 20)
        Me.tbTekst.TabIndex = 48
        '
        'tbAantal
        '
        Me.tbAantal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbAantal.Location = New System.Drawing.Point(883, 588)
        Me.tbAantal.Name = "tbAantal"
        Me.tbAantal.Size = New System.Drawing.Size(108, 20)
        Me.tbAantal.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(766, 589)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Nr of Books:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(666, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Sort:"
        '
        'cbSorteren
        '
        Me.cbSorteren.AutoCompleteCustomSource.AddRange(New String() {"Datum", "Naam", "Rekening", "Code", "Categorie", "Boekingsnummer"})
        Me.cbSorteren.FormattingEnabled = True
        Me.cbSorteren.Items.AddRange(New Object() {"Textnr", "Issued", "Authors"})
        Me.cbSorteren.Location = New System.Drawing.Point(718, 64)
        Me.cbSorteren.Name = "cbSorteren"
        Me.cbSorteren.Size = New System.Drawing.Size(117, 21)
        Me.cbSorteren.TabIndex = 56
        '
        'cbDirection
        '
        Me.cbDirection.AutoCompleteCustomSource.AddRange(New String() {"Datum", "Naam", "Rekening", "Code", "Categorie", "Boekingsnummer"})
        Me.cbDirection.FormattingEnabled = True
        Me.cbDirection.Items.AddRange(New Object() {"asc", "desc"})
        Me.cbDirection.Location = New System.Drawing.Point(849, 64)
        Me.cbDirection.Name = "cbDirection"
        Me.cbDirection.Size = New System.Drawing.Size(50, 21)
        Me.cbDirection.TabIndex = 57
        Me.cbDirection.Text = "asc"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(659, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Shelf:"
        '
        'cbShelf
        '
        Me.cbShelf.AutoCompleteCustomSource.AddRange(New String() {"Af", "Bij"})
        Me.cbShelf.FormattingEnabled = True
        Me.cbShelf.Location = New System.Drawing.Point(717, 8)
        Me.cbShelf.Name = "cbShelf"
        Me.cbShelf.Size = New System.Drawing.Size(274, 21)
        Me.cbShelf.TabIndex = 58
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(366, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 17)
        Me.Label13.TabIndex = 61
        Me.Label13.Text = "Type:"
        '
        'cbType
        '
        Me.cbType.FormattingEnabled = True
        Me.cbType.Items.AddRange(New Object() {"Text", "Collection", "Dataset", "Image", "MovingImage", "Sound", "StillImage"})
        Me.cbType.Location = New System.Drawing.Point(421, 35)
        Me.cbType.Name = "cbType"
        Me.cbType.Size = New System.Drawing.Size(205, 21)
        Me.cbType.TabIndex = 60
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(667, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 17)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "LoC:"
        '
        'cbLOC
        '
        Me.cbLOC.FormattingEnabled = True
        Me.cbLOC.Items.AddRange(New Object() {"AC-Collections. Series. Collected works", "AE-Encyclopedias", "AG-Dictionaries and other general reference works", "AM-Museums. Collectors and collecting", "AP-Periodicals", "AS-Academies and learned societies", "AY-Yearbooks. Almanacs. Directories", "AZ-History of scholarship and learning. The humanities", "B-Philosophy (General)", "BC-Logic", "BD-Speculative philosophy", "BF-Psychology", "BH-Aesthetics", "BJ-Ethics", "BL-Religions. Mythology. Rationalism", "BM-Judaism", "BP-Islam. Bahaism. Theosophy, etc.", "BQ-Buddhism", "BR-Christianity", "BS-The Bible", "BT-Doctrinal Theology", "BV-Practical Theology", "BX-Christian Denominations", "CB-History of Civilization", "CC-Archaeology", "CE-Technical Chronology. Calendar", "CJ-Numismatics", "CN-Inscriptions. Epigraphy", "CR-Heraldry", "CS-Genealogy", "CT-Biography", "D-History (General)", "D501-History World War I", "D731-History World War II", "DA-Great Britain", "DB-Austria  Liechtenstein  Hungary  Czechoslovakia", "DC-France - Andorra - Monaco", "DD-Germany", "DE-Greco-Roman World", "DF-Greece", "DG-Italy  Malta", "DH-Low Countries  Benelux Countries", "DJ-Netherlands (Holland)", "DJK-Eastern Europe (General)", "DK-Russia. Soviet Union. Former Soviet Republics Poland", "DL-Northern Europe. Scandinavia", "DP-Spain  Portugal", "DQ-Switzerland", "DR-Balkan Peninsula", "DS-Asia", "DT-Africa", "DU-Oceania (South Seas)", "DX-Romanies", "E011-History America America", "E151-History America United States", "E186-History America Colonial history", "E201-History America The Revolution", "E300-History America Revolution to the Civil War", "E456-History America Civil War period", "E660-History America Late nineteenth century", "E740-History America Twentieth century", "E838-History America Later twentieth century", "E895-History America Twenty-first century", "F001-United States local history: New England", "F1001-North America local history: Canada", "F1201-North America local history: Mexico", "F1401-Latin America local history: General", "F1461-Latin America local history: Guatemala", "F1481-Latin America local history: El Salvador", "F1501-Latin America local history: Honduras", "F1521-Latin America local history: Nicaragua", "F1541-Latin America local history: Costa Rica", "F1561-Latin America local history: Panama", "F1601-History of the Americas: West Indies", "F1751-History of the Americas: West Indies: Cuba", "F1861-History of the Americas: West Indies: Jamaica", "F1900-West Indies local History: Hispaniola", "F1951-West Indies local History: Puerto Rico", "F2001-History of the Americas: Lesser Antilles", "F2001-History of the Americas: Lesser Antilles", "F206-United States local history: The South", "F2131-History of the Americas: West Indies", "F2155-History of the Americas: Caribbean Area", "F2201-Latin America local history: South America", "F2251-Latin America local history: Colombia", "F2301-Latin America local history: Venezuela", "F2351-Latin America local history: Guiana", "F2501-Latin America local history: Brazil", "F2661-Latin America local history: Paraquay", "F2701-Latin America local history: Uruquay", "F2801-Latin America local history: Argentina", "F296-United States local history: Gulf States", "F3051-Latin America local history: Chili", "F3301-Latin America local history: Bolivia", "F3401-Latin America local history: Peru", "F3401-Latin America local history: Peru", "F350.5-United States local history: Mississipi River", "F3701-Latin America local history: Ecuador", "F396-United States local history: Old SouthWest", "F476-United States local history: Old NorthWest", "F516-United States local history: Ohio River", "F590.3-United States local history: The West", "F721-United States local history: Rocky Mountains", "F786-United States local history: New SouthWest", "F580.5-United States local history: Pacific States", "F975-United States local history: Central American", "G-Geography (General). Atlases. Maps", "GA-Mathematical geography. Cartography", "GB-Physical geography", "GC-Oceanography", "GF-Human ecology. Anthropogeography", "GN-Anthropology", "GR-Folklore", "GT-Manners and customs (General)", "GV-Recreation. Leisure", "H -ocial sciences (General)", "HA-Statistics", "HB-Economic theory. Demography", "HC-Economic history and conditions", "HD-Industries. Land use. Labor", "HE-Transportation and communications", "HF-Commerce", "HG-Finance", "HJ-Public finance", "HM-Sociology (General)", "HN-Social history and conditions. Social problems. Social reform", "HQ-The family. Marriage. Women", "HS-Societies: secret, benevolent, etc.", "HT-Communities. Classes. Races", "HV-Social pathology. Social and public welfare. Criminology", "HX-Socialism. Communism. Anarchism", "J-General legislative and executive papers", "JA-Political science (General)", "JC-Political theory", "JF-Political institutions and public administration", "JK-Political institutions and public administration (United States)", "JL-Political institutions and public administration (Canada, etc.)", "JN-Political institutions and public administration (Europe)", "JQ-Political institutions and public administration (Asia, Africa,etc.)", "JS-Local government. Municipal government", "JV-Colonies and colonization. Emigration and immigration.", "JX-International law, see JZ and KZ (obsolete)", "JZ-International relations ", "K-Law in general. Comparative and uniform law. Jurisprudence", "KBM-Jewish law", "KBR-History of canon law", "KD-United Kingdom and Ireland", "KDZ-America. North America", "KE-Canada", "KF-United States", "KH-South America", "KJ-Europe", "KL-Asia and Eurasia, Africa, Pacific Area, and Antarctica", "KN-South Asia", "KNX-Japan", "KP-South Asia", "KZ-Law of Nations", "L-Education (General)", "LA-History of education", "LB-Theory and practice of education", "LC-Special aspects of education", "LD-Individual institutions - United States", "LE-Individual institutions - America (except United States)", "LF-Individual institutions - Europe", "LH-College and school magazines and papers", "LT-Textbooks ", "M-Music", "ML-Literature on music", "MT-Instruction and study ", "N-Visual arts", "NA-Architecture", "NB-Sculpture", "NC-Drawing. Design. Illustration", "ND-Painting", "NE-Print media", "NK-Decorative arts", "NX-Arts in general", "P-Philology. Linguistics", "PA-Greek language and literature. Latin language and literature", "PB-Modern languages. Celtic languages", "PC-Romance languages", "PD-Germanic languages. Scandinavian languages", "PE-English language", "PF-West Germanic languages", "PG-Slavic languages. Baltic languages. Albanian language", "PH-Uralic languages. Basque language", "PJ-Oriental languages and literatures", "PK-Indo-Iranian languages and literatures", "PL-Languages and literatures of Eastern Asia, Africa, Oceania", "PM-Hyperborean, Indian, and artificial languages", "PN-Literature (General)", "PQ-French literature Italian Spanish Portuguese literature", "PR-English literature", "PS-American literature", "PT-German literature - Dutch literature - Flemish literature", "PZ-Fiction and juvenile belles lettres ", "Q-Science (General)", "QA-Mathematics", "QB-Astronomy", "QC-Physics", "QD-Chemistry", "QE-Geology", "QH-Natural history - Biology", "QK-Botany", "QL-Zoology", "QM-Human anatomy", "QP-Physiology", "QR-Microbiology", "R-Medicine (General)", "RA-Public aspects of medicine", "RB-Pathology", "RC-Internal medicine", "RD-Surgery", "RE-Ophthalmology", "RF-Otorhinolaryngology", "RG-Gynecology and obstetrics", "RJ-Pediatrics", "RK-Dentistry", "RL-Dermatology", "RM-Therapeutics. Pharmacology", "RS-Pharmacy and materia medica", "RT-Nursing", "RV-Botanic, Thomsonian, and eclectic medicine", "RX-Homeopathy", "RZ-Other systems of medicine", "S-Agriculture (General)", "SB-Plant culture", "SD-Forestry", "SF-Animal culture", "SH-Aquaculture. Fisheries. Angling", "SK-Hunting sports", "T-Technology (General)", "TA-Engineering (General). Civil engineering", "TC-Hydraulic engineering. Ocean engineering", "TD-Environmental technology. Sanitary engineering", "TE-Highway engineering. Roads and pavements", "TF-Railroad engineering and operation", "TG-Bridge engineering", "TH-Building construction", "TJ-Mechanical engineering and machinery", "TK-Electrical engineering. Electronics. Nuclear engineering", "TL-Motor vehicles. Aeronautics. Astronautics", "TN-Mining engineering. Metallurgy", "TP-Chemical technology", "TR-Photography", "TS-Manufactures", "TT-Handicrafts. Arts and crafts", "TX-Home economics", "U-Military science (General)", "UA-Armies: Organization, distribution, military situation", "UB-Military administration", "UC-Maintenance and transportation", "UD-Infantry", "UE-Cavalry. Armor", "UF-Artillery", "UG-Military engineering. Air forces", "UH-Other services", "V-Naval science (General)", "VA-Navies: Organization, distribution, naval situation", "VB-Naval administration", "VE-Marines", "VF-Naval ordnance", "VG-Minor services of navies", "VK-Navigation. Merchant marine", "VM-Naval architecture. Shipbuilding. Marine engineering", "Z-Bibliography, Library Science"})
        Me.cbLOC.Location = New System.Drawing.Point(717, 35)
        Me.cbLOC.Name = "cbLOC"
        Me.cbLOC.Size = New System.Drawing.Size(274, 21)
        Me.cbLOC.TabIndex = 62
        '
        'tbCategory
        '
        Me.tbCategory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbCategory.Location = New System.Drawing.Point(13, 588)
        Me.tbCategory.Name = "tbCategory"
        Me.tbCategory.Size = New System.Drawing.Size(400, 20)
        Me.tbCategory.TabIndex = 64
        '
        'tbLocc
        '
        Me.tbLocc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbLocc.Location = New System.Drawing.Point(419, 588)
        Me.tbLocc.Name = "tbLocc"
        Me.tbLocc.Size = New System.Drawing.Size(183, 20)
        Me.tbLocc.TabIndex = 65
        '
        'btnWeb
        '
        Me.btnWeb.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnWeb.Location = New System.Drawing.Point(13, 639)
        Me.btnWeb.Name = "btnWeb"
        Me.btnWeb.Size = New System.Drawing.Size(98, 33)
        Me.btnWeb.TabIndex = 66
        Me.btnWeb.Text = "Get Ebook"
        Me.btnWeb.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 8)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(979, 625)
        Me.WebBrowser1.TabIndex = 74
        Me.WebBrowser1.Visible = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.Location = New System.Drawing.Point(117, 639)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(35, 33)
        Me.Button8.TabIndex = 93
        Me.Button8.UseVisualStyleBackColor = True
        '
        'SearchEbooks
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 675)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnWeb)
        Me.Controls.Add(Me.tbLocc)
        Me.Controls.Add(Me.tbCategory)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cbLOC)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbShelf)
        Me.Controls.Add(Me.cbDirection)
        Me.Controls.Add(Me.cbSorteren)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tbAantal)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.tbTekst)
        Me.Controls.Add(Me.lblTooltip)
        Me.Controls.Add(Me.cbAccount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tbOmschrijving)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbCategorie)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbAuthors)
        Me.Controls.Add(Me.tbEnd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "SearchEbooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Search/Browse Ebooks "
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents tbStart As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbEnd As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbAuthors As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCategorie As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbOmschrijving As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbAccount As System.Windows.Forms.ComboBox
    Friend WithEvents lblTooltip As System.Windows.Forms.Label
    Friend WithEvents tbTekst As System.Windows.Forms.TextBox
    Friend WithEvents tbAantal As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbSorteren As System.Windows.Forms.ComboBox
    Friend WithEvents cbDirection As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbShelf As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbLOC As System.Windows.Forms.ComboBox
    Friend WithEvents tbCategory As System.Windows.Forms.TextBox
    Friend WithEvents tbLocc As System.Windows.Forms.TextBox
    Friend WithEvents btnWeb As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
