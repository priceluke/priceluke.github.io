Imports System.IO
Imports System.Text.RegularExpressions
Imports System.IO.Compression
Public Class frmMenu
    Private Sub Form1_ClientSizeChanged(sender As Object, e As EventArgs) Handles Me.ClientSizeChanged
        dash_parentWrapper.Height = Me.Height - 80
        footer_label.Left = (Me.Width / 2) - (footer_label.Width / 2)
        list_currentJob.Width = dash_parentWrapper.Width
    End Sub
    Public Sub update_menu()
        recent_JobsListBox.Items.Clear()
        pinned_JobsListBox.Items.Clear()
        combo_productdesc.Items.Clear()
        combo_productID.Items.Clear()
        recent_JobsListBox.Items.Add("   ---    FREQUENT JOBS    ---   ")
        pinned_JobsListBox.Items.Add("   ---     PINNED JOBS     ---   ")
        recent_JobsListBox.Items.Add("_________________________________")
        pinned_JobsListBox.Items.Add("_________________________________")
        recent_JobsListBox.Items.Add("Job Name        " & "       Count")
        pinned_JobsListBox.Items.Add("Job Name        " & "       Count")
        recent_JobsListBox.Items.Add("_________________________________")
        pinned_JobsListBox.Items.Add("_________________________________")
        Dim list_productid As New List(Of String)
        Dim list_productdesc As New List(Of String)
        list_productid.Clear()
        list_productdesc.Clear()
        Dim i As Integer
        Dim filenum = FreeFile()
        FileOpen(filenum, "Products.dat", OpenMode.Random, , , Len(product_record))
        If LOF(filenum) / Len(product_record) = 0 Then
        Else
            For i = 1 To LOF(filenum) / Len(product_record)
                FileGet(filenum, product_record, i)
                list_productid.Add(product_record.product_id)
                list_productdesc.Add(product_record.product_desc)
            Next i
        End If
        FileClose(filenum)
        '''''''''''''''''''''''''''''''''''''''''''
        Dim n As Integer
        Dim freefile_job = FreeFile()
        FileOpen(freefile_job, "Jobs.dat", OpenMode.Random, , , Len(job_record))
        Dim Job_Table As New System.Data.DataTable
        Job_Table.Columns.Add("JobName")
        Job_Table.Columns.Add("Count", GetType(Integer))
        Job_Table.Columns.Add("ID", GetType(Integer))
        Dim no_pinned_items As Boolean = True
        'first row = Job Names
        'Second row = Count
        'third row = Job ID
        If LOF(freefile_job) / Len(job_record) = 0 Then
            recent_JobsListBox.Items.Add("           No Records            ")
            pinned_JobsListBox.Items.Add("           No Records            ")
        Else
            For n = 1 To LOF(freefile_job) / Len(job_record)
                FileGet(freefile_job, job_record, n)
                If job_record.job_pinned Then
                    pinned_JobsListBox.Items.Add(job_record.job_name & "       " & job_record.job_count)
                    no_pinned_items = False
                End If
                Job_Table.Rows.Add(job_record.job_name, job_record.job_count, job_record.job_id)
            Next n
            If no_pinned_items Then
                pinned_JobsListBox.Items.Add("         No Pinned Jobs          ")
            End If
        End If
        FileClose(freefile_job)
        '''''''''''''''''''''''''''''''''''''''''''
        'Now must sort the Jobs array by count
        Dim sorted_job As DataView = Job_Table.DefaultView
        sorted_job.Sort = "Count DESC"
        'For Each row As DataRow In sorted_job.rows
        '    recent_JobsListBox.Items.Add(row("JobName"))
        'Next row
        For Each rowView As DataRowView In sorted_job
            Dim row As DataRow = rowView.Row
            ' Do something '
            'MsgBox(row("Count"))
            recent_JobsListBox.Items.Add(row("JobName") & "       " & row("Count"))
        Next

        Dim array_jobs(sorted_job.Count, 2) As String
        '''''''''''''''''''''''''''''''''''''''''''
        Dim autofill_productid As New AutoCompleteStringCollection
        autofill_productid.AddRange(list_productid.ToArray)
        combo_productID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_productID.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_productID.AutoCompleteCustomSource = autofill_productid

        combo_productID.Items.AddRange(list_productid.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''
        Dim autofill_productdesc As New AutoCompleteStringCollection
        autofill_productdesc.AddRange(list_productdesc.ToArray)
        combo_productdesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_productdesc.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_productdesc.AutoCompleteCustomSource = autofill_productdesc
        combo_productdesc.Items.AddRange(list_productdesc.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''
        Dim list_numbers() As String = ({"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "110", "111", "112", "113", "114", "115", "116", "117", "118", "119", "120", "121", "122", "123", "124", "125", "126", "127", "128", "129", "130", "131", "132", "133", "134", "135", "136", "137", "138", "139", "140", "141", "142", "143", "144", "145", "146", "147", "148", "149", "150", "151", "152", "153", "154", "155", "156", "157", "158", "159", "160", "161", "162", "163", "164", "165", "166", "167", "168", "169", "170", "171", "172", "173", "174", "175", "176", "177", "178", "179", "180", "181", "182", "183", "184", "185", "186", "187", "188", "189", "190", "191", "192", "193", "194", "195", "196", "197", "198", "199", "200", "201", "202", "203", "204", "205", "206", "207", "208", "209", "210", "211", "212", "213", "214", "215", "216", "217", "218", "219", "220", "221", "222", "223", "224", "225", "226", "227", "228", "229", "230", "231", "232", "233", "234", "235", "236", "237", "238", "239", "240", "241", "242", "243", "244", "245", "246", "247", "248", "249", "250", "251", "252", "253", "254", "255", "256", "257", "258", "259", "260", "261", "262", "263", "264", "265", "266", "267", "268", "269", "270", "271", "272", "273", "274", "275", "276", "277", "278", "279", "280", "281", "282", "283", "284", "285", "286", "287", "288", "289", "290", "291", "292", "293", "294", "295", "296", "297", "298", "299", "300", "301", "302", "303", "304", "305", "306", "307", "308", "309", "310", "311", "312", "313", "314", "315", "316", "317", "318", "319", "320", "321", "322", "323", "324", "325", "326", "327", "328", "329", "330", "331", "332", "333", "334", "335", "336", "337", "338", "339", "340", "341", "342", "343", "344", "345", "346", "347", "348", "349", "350", "351", "352", "353", "354", "355", "356", "357", "358", "359", "360", "361", "362", "363", "364", "365", "366", "367", "368", "369", "370", "371", "372", "373", "374", "375", "376", "377", "378", "379", "380", "381", "382", "383", "384", "385", "386", "387", "388", "389", "390", "391", "392", "393", "394", "395", "396", "397", "398", "399", "400", "401", "402", "403", "404", "405", "406", "407", "408", "409", "410", "411", "412", "413", "414", "415", "416", "417", "418", "419", "420", "421", "422", "423", "424", "425", "426", "427", "428", "429", "430", "431", "432", "433", "434", "435", "436", "437", "438", "439", "440", "441", "442", "443", "444", "445", "446", "447", "448", "449", "450", "451", "452", "453", "454", "455", "456", "457", "458", "459", "460", "461", "462", "463", "464", "465", "466", "467", "468", "469", "470", "471", "472", "473", "474", "475", "476", "477", "478", "479", "480", "481", "482", "483", "484", "485", "486", "487", "488", "489", "490", "491", "492", "493", "494", "495", "496", "497", "498", "499", "500", "501", "502", "503", "504", "505", "506", "507", "508", "509", "510", "511", "512", "513", "514", "515", "516", "517", "518", "519", "520", "521", "522", "523", "524", "525", "526", "527", "528", "529", "530", "531", "532", "533", "534", "535", "536", "537", "538", "539", "540", "541", "542", "543", "544", "545", "546", "547", "548", "549", "550", "551", "552", "553", "554", "555", "556", "557", "558", "559", "560", "561", "562", "563", "564", "565", "566", "567", "568", "569", "570", "571", "572", "573", "574", "575", "576", "577", "578", "579", "580", "581", "582", "583", "584", "585", "586", "587", "588", "589", "590", "591", "592", "593", "594", "595", "596", "597", "598", "599", "600", "601", "602", "603", "604", "605", "606", "607", "608", "609", "610", "611", "612", "613", "614", "615", "616", "617", "618", "619", "620", "621", "622", "623", "624", "625", "626", "627", "628", "629", "630", "631", "632", "633", "634", "635", "636", "637", "638", "639", "640", "641", "642", "643", "644", "645", "646", "647", "648", "649", "650", "651", "652", "653", "654", "655", "656", "657", "658", "659", "660", "661", "662", "663", "664", "665", "666", "667", "668", "669", "670", "671", "672", "673", "674", "675", "676", "677", "678", "679", "680", "681", "682", "683", "684", "685", "686", "687", "688", "689", "690", "691", "692", "693", "694", "695", "696", "697", "698", "699", "700", "701", "702", "703", "704", "705", "706", "707", "708", "709", "710", "711", "712", "713", "714", "715", "716", "717", "718", "719", "720", "721", "722", "723", "724", "725", "726", "727", "728", "729", "730", "731", "732", "733", "734", "735", "736", "737", "738", "739", "740", "741", "742", "743", "744", "745", "746", "747", "748", "749", "750", "751", "752", "753", "754", "755", "756", "757", "758", "759", "760", "761", "762", "763", "764", "765", "766", "767", "768", "769", "770", "771", "772", "773", "774", "775", "776", "777", "778", "779", "780", "781", "782", "783", "784", "785", "786", "787", "788", "789", "790", "791", "792", "793", "794", "795", "796", "797", "798", "799", "800", "801", "802", "803", "804", "805", "806", "807", "808", "809", "810", "811", "812", "813", "814", "815", "816", "817", "818", "819", "820", "821", "822", "823", "824", "825", "826", "827", "828", "829", "830", "831", "832", "833", "834", "835", "836", "837", "838", "839", "840", "841", "842", "843", "844", "845", "846", "847", "848", "849", "850", "851", "852", "853", "854", "855", "856", "857", "858", "859", "860", "861", "862", "863", "864", "865", "866", "867", "868", "869", "870", "871", "872", "873", "874", "875", "876", "877", "878", "879", "880", "881", "882", "883", "884", "885", "886", "887", "888", "889", "890", "891", "892", "893", "894", "895", "896", "897", "898", "899", "900", "901", "902", "903", "904", "905", "906", "907", "908", "909", "910", "911", "912", "913", "914", "915", "916", "917", "918", "919", "920", "921", "922", "923", "924", "925", "926", "927", "928", "929", "930", "931", "932", "933", "934", "935", "936", "937", "938", "939", "940", "941", "942", "943", "944", "945", "946", "947", "948", "949", "950", "951", "952", "953", "954", "955", "956", "957", "958", "959", "960", "961", "962", "963", "964", "965", "966", "967", "968", "969", "970", "971", "972", "973", "974", "975", "976", "977", "978", "979", "980", "981", "982", "983", "984", "985", "986", "987", "988", "989", "990", "991", "992", "993", "994", "995", "996", "997", "998", "999", "1000", "1001", "1002", "1003", "1004", "1005", "1006", "1007", "1008", "1009", "1010", "1011", "1012", "1013", "1014", "1015", "1016", "1017", "1018", "1019", "1020", "1021", "1022", "1023", "1024", "1025", "1026", "1027", "1028", "1029", "1030", "1031", "1032", "1033", "1034", "1035", "1036", "1037", "1038", "1039", "1040", "1041", "1042", "1043", "1044", "1045", "1046", "1047", "1048", "1049", "1050", "1051", "1052", "1053", "1054", "1055", "1056", "1057", "1058", "1059", "1060", "1061", "1062", "1063", "1064", "1065", "1066", "1067", "1068", "1069", "1070", "1071", "1072", "1073", "1074", "1075", "1076", "1077", "1078", "1079", "1080", "1081", "1082", "1083", "1084", "1085", "1086", "1087", "1088", "1089", "1090", "1091", "1092", "1093", "1094", "1095", "1096", "1097", "1098", "1099", "1100", "1101", "1102", "1103", "1104", "1105", "1106", "1107", "1108", "1109", "1110", "1111", "1112", "1113", "1114", "1115", "1116", "1117", "1118", "1119", "1120", "1121", "1122", "1123", "1124", "1125", "1126", "1127", "1128", "1129", "1130", "1131", "1132", "1133", "1134", "1135", "1136", "1137", "1138", "1139", "1140", "1141", "1142", "1143", "1144", "1145", "1146", "1147", "1148", "1149", "1150", "1151", "1152", "1153", "1154", "1155", "1156", "1157", "1158", "1159", "1160", "1161", "1162", "1163", "1164", "1165", "1166", "1167", "1168", "1169", "1170", "1171", "1172", "1173", "1174", "1175", "1176", "1177", "1178", "1179", "1180", "1181", "1182", "1183", "1184", "1185", "1186", "1187", "1188", "1189", "1190", "1191", "1192", "1193", "1194", "1195", "1196", "1197", "1198", "1199", "1200", "1201", "1202", "1203", "1204", "1205", "1206", "1207", "1208", "1209", "1210", "1211", "1212", "1213", "1214", "1215", "1216", "1217", "1218", "1219", "1220", "1221", "1222", "1223", "1224", "1225", "1226", "1227", "1228", "1229", "1230", "1231", "1232", "1233", "1234", "1235", "1236", "1237", "1238", "1239", "1240", "1241", "1242", "1243", "1244", "1245", "1246", "1247", "1248", "1249", "1250", "1251", "1252", "1253", "1254", "1255", "1256", "1257", "1258", "1259", "1260", "1261", "1262", "1263", "1264", "1265", "1266", "1267", "1268", "1269", "1270", "1271", "1272", "1273", "1274", "1275", "1276", "1277", "1278", "1279", "1280", "1281", "1282", "1283", "1284", "1285", "1286", "1287", "1288", "1289", "1290", "1291", "1292", "1293", "1294", "1295", "1296", "1297", "1298", "1299", "1300", "1301", "1302", "1303", "1304", "1305", "1306", "1307", "1308", "1309", "1310", "1311", "1312", "1313", "1314", "1315", "1316", "1317", "1318", "1319", "1320", "1321", "1322", "1323", "1324", "1325", "1326", "1327", "1328", "1329", "1330", "1331", "1332", "1333", "1334", "1335", "1336", "1337", "1338", "1339", "1340", "1341", "1342", "1343", "1344", "1345", "1346", "1347", "1348", "1349", "1350", "1351", "1352", "1353", "1354", "1355", "1356", "1357", "1358", "1359", "1360", "1361", "1362", "1363", "1364", "1365", "1366", "1367", "1368", "1369", "1370", "1371", "1372", "1373", "1374", "1375", "1376", "1377", "1378", "1379", "1380", "1381", "1382", "1383", "1384", "1385", "1386", "1387", "1388", "1389", "1390", "1391", "1392", "1393", "1394", "1395", "1396", "1397", "1398", "1399", "1400", "1401", "1402", "1403", "1404", "1405", "1406", "1407", "1408", "1409", "1410", "1411", "1412", "1413", "1414", "1415", "1416", "1417", "1418", "1419", "1420", "1421", "1422", "1423", "1424", "1425", "1426", "1427", "1428", "1429", "1430", "1431", "1432", "1433", "1434", "1435", "1436", "1437", "1438", "1439", "1440", "1441", "1442", "1443", "1444", "1445", "1446", "1447", "1448", "1449", "1450", "1451", "1452", "1453", "1454", "1455", "1456", "1457", "1458", "1459", "1460", "1461", "1462", "1463", "1464", "1465", "1466", "1467", "1468", "1469", "1470", "1471", "1472", "1473", "1474", "1475", "1476", "1477", "1478", "1479", "1480", "1481", "1482", "1483", "1484", "1485", "1486", "1487", "1488", "1489", "1490", "1491", "1492", "1493", "1494", "1495", "1496", "1497", "1498", "1499", "1500", "1501", "1502", "1503", "1504", "1505", "1506", "1507", "1508", "1509", "1510", "1511", "1512", "1513", "1514", "1515", "1516", "1517", "1518", "1519", "1520", "1521", "1522", "1523", "1524", "1525", "1526", "1527", "1528", "1529", "1530", "1531", "1532", "1533", "1534", "1535", "1536", "1537", "1538", "1539", "1540", "1541", "1542", "1543", "1544", "1545", "1546", "1547", "1548", "1549", "1550", "1551", "1552", "1553", "1554", "1555", "1556", "1557", "1558", "1559", "1560", "1561", "1562", "1563", "1564", "1565", "1566", "1567", "1568", "1569", "1570", "1571", "1572", "1573", "1574", "1575", "1576", "1577", "1578", "1579", "1580", "1581", "1582", "1583", "1584", "1585", "1586", "1587", "1588", "1589", "1590", "1591", "1592", "1593", "1594", "1595", "1596", "1597", "1598", "1599", "1600", "1601", "1602", "1603", "1604", "1605", "1606", "1607", "1608", "1609", "1610", "1611", "1612", "1613", "1614", "1615", "1616", "1617", "1618", "1619", "1620", "1621", "1622", "1623", "1624", "1625", "1626", "1627", "1628", "1629", "1630", "1631", "1632", "1633", "1634", "1635", "1636", "1637", "1638", "1639", "1640", "1641", "1642", "1643", "1644", "1645", "1646", "1647", "1648", "1649", "1650", "1651", "1652", "1653", "1654", "1655", "1656", "1657", "1658", "1659", "1660", "1661", "1662", "1663", "1664", "1665", "1666", "1667", "1668", "1669", "1670", "1671", "1672", "1673", "1674", "1675", "1676", "1677", "1678", "1679", "1680", "1681", "1682", "1683", "1684", "1685", "1686", "1687", "1688", "1689", "1690", "1691", "1692", "1693", "1694", "1695", "1696", "1697", "1698", "1699", "1700", "1701", "1702", "1703", "1704", "1705", "1706", "1707", "1708", "1709", "1710", "1711", "1712", "1713", "1714", "1715", "1716", "1717", "1718", "1719", "1720", "1721", "1722", "1723", "1724", "1725", "1726", "1727", "1728", "1729", "1730", "1731", "1732", "1733", "1734", "1735", "1736", "1737", "1738", "1739", "1740", "1741", "1742", "1743", "1744", "1745", "1746", "1747", "1748", "1749", "1750", "1751", "1752", "1753", "1754", "1755", "1756", "1757", "1758", "1759", "1760", "1761", "1762", "1763", "1764", "1765", "1766", "1767", "1768", "1769", "1770", "1771", "1772", "1773", "1774", "1775", "1776", "1777", "1778", "1779", "1780", "1781", "1782", "1783", "1784", "1785", "1786", "1787", "1788", "1789", "1790", "1791", "1792", "1793", "1794", "1795", "1796", "1797", "1798", "1799", "1800", "1801", "1802", "1803", "1804", "1805", "1806", "1807", "1808", "1809", "1810", "1811", "1812", "1813", "1814", "1815", "1816", "1817", "1818", "1819", "1820", "1821", "1822", "1823", "1824", "1825", "1826", "1827", "1828", "1829", "1830", "1831", "1832", "1833", "1834", "1835", "1836", "1837", "1838", "1839", "1840", "1841", "1842", "1843", "1844", "1845", "1846", "1847", "1848", "1849", "1850", "1851", "1852", "1853", "1854", "1855", "1856", "1857", "1858", "1859", "1860", "1861", "1862", "1863", "1864", "1865", "1866", "1867", "1868", "1869", "1870", "1871", "1872", "1873", "1874", "1875", "1876", "1877", "1878", "1879", "1880", "1881", "1882", "1883", "1884", "1885", "1886", "1887", "1888", "1889", "1890", "1891", "1892", "1893", "1894", "1895", "1896", "1897", "1898", "1899", "1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109", "2110", "2111", "2112", "2113", "2114", "2115", "2116"})
        Dim autofill_quantity As New AutoCompleteStringCollection
        autofill_quantity.AddRange(list_numbers.ToArray)
        combo_quantity.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        combo_quantity.AutoCompleteSource = AutoCompleteSource.CustomSource
        combo_quantity.AutoCompleteCustomSource = autofill_quantity
        combo_quantity.Items.AddRange(list_numbers.ToArray())
        ''''''''''''''''''''''''''''''''''''''''''''''''
        Try
            combo_productID.Text = combo_productID.Items(0).ToString
        Catch
            combo_productID.Items.Add("No Records")
            combo_productID.Text = combo_productID.Items(0).ToString
        End Try
        Try
            combo_productdesc.Text = combo_productdesc.Items(0).ToString
        Catch ex As Exception
            combo_productdesc.Items.Add("No Records")
            combo_productdesc.Text = combo_productdesc.Items(0).ToString
        End Try
        TextBox4.Clear()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        importRecords.Filter = "Zip Files|*.zip"
        '
        'DataGridView1.Visible = False
        refresh_from_current_job()
        '''''''''''''''''''''''''''''''''''''''''
        recent_JobsListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        pinned_JobsListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dash_manafactureWrapper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        dash_jobsWrapper.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        list_currentJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        footer_label.Anchor = (System.Windows.Forms.AnchorStyles.Bottom)
        label_productAssLocation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productDesc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        label_productID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        btn_addToJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top And System.Windows.Forms.AnchorStyles.Bottom And System.Windows.Forms.AnchorStyles.Right And System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        btnConfirmJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_Clear_Current_Job.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_search_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btn_search_desc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btnRemoveFromJob.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dash_manafactureWrapper.CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_addToJob.Cursor = Cursors.Hand
        btn_addToJob.FlatStyle = FlatStyle.Flat
        With btn_addToJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnConfirmJob.Cursor = Cursors.Hand
        btnConfirmJob.FlatStyle = FlatStyle.Flat
        With btnConfirmJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_Clear_Current_Job.Cursor = Cursors.Hand
        btn_Clear_Current_Job.FlatStyle = FlatStyle.Flat
        With btn_Clear_Current_Job.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btnRemoveFromJob.Cursor = Cursors.Hand
        btnRemoveFromJob.FlatStyle = FlatStyle.Flat
        With btnRemoveFromJob.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_search_desc.Cursor = Cursors.Hand
        btn_search_desc.FlatStyle = FlatStyle.Flat
        With btn_search_desc.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        btn_search_id.Cursor = Cursors.Hand
        btn_search_id.FlatStyle = FlatStyle.Flat
        With btn_search_id.FlatAppearance
            .BorderColor = Color.Red
            .BorderSize = 0
            .MouseDownBackColor = Color.LightSkyBlue
            .MouseOverBackColor = Color.LightGray
        End With
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        list_currentJob.BorderStyle = BorderStyle.FixedSingle
        list_currentJob.DrawMode = DrawMode.OwnerDrawFixed
        list_currentJob.ItemHeight += 5
        '''''''''''''''''''''''''''''''''''''''''''
    End Sub
    Private Sub list_currentJob_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles list_currentJob.DrawItem
        If e.Index Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If
        If list_currentJob.SelectedIndex = e.Index Then
            e.Graphics.FillRectangle(Brushes.LightSkyBlue, e.Bounds)
            Try
                e.Graphics.DrawString(list_currentJob.Items(e.Index).ToString, Me.Font, Brushes.White, 0, e.Bounds.Y + 2)
            Catch
            End Try
        Else
            e.Graphics.DrawString(list_currentJob.Items(e.Index).ToString, Me.Font, Brushes.Black, 0, e.Bounds.Y + 2)
        End If
        e.Graphics.DrawRectangle(Pens.Gray, e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height)
    End Sub
    Private Sub list_currentJob_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_currentJob.SelectedIndexChanged
        list_currentJob.Refresh()
    End Sub

    Private Sub DiscardingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscardingToolStripMenuItem.Click
        If MsgBox("Are you sure you want to quit? All data from current job will be lost.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Exit - Discarding") = Windows.Forms.DialogResult.Yes Then
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            End
        End If
    End Sub
    Private Sub SavingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavingToolStripMenuItem.Click
        If MsgBox("Are you sure you want to quit? All data from current session will be saved.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Exit - Saving") = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub MyForm_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show(" Are you sure you want to quit? All unsaved data will be lost.", "Exit - Menu", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub JobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobsToolStripMenuItem.Click
        frmRecordEdit_Job.Show()
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click
        frmRecordEdit_Product.Show()
    End Sub

    Private Sub LocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationToolStripMenuItem.Click
        frmRecordEdit_Location.Show()
    End Sub

    Private Sub ComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComponentToolStripMenuItem.Click
        frmRecordEdit_Component.Show()
    End Sub
    Sub info_fill(e As String, x As String)
        Dim filenum = FreeFile()
        Dim search_parameter As String = x
        Dim i As Integer
        FileOpen(filenum, "Products.dat", OpenMode.Random, , , Len(product_record))
        If LOF(filenum) / Len(job_record) = 0 Then
        Else
            For i = 1 To LOF(filenum) / Len(product_record)
                FileGet(filenum, product_record, i)
                If e = "Description" Then
                    If product_record.product_desc = search_parameter Then
                        combo_productID.Text = product_record.product_id
                        TextBox4.Text = product_record.product_ass_location
                    End If
                Else
                    If product_record.product_id = search_parameter Then
                        combo_productdesc.SelectedItem = product_record.product_desc
                        TextBox4.Text = product_record.product_ass_location
                    End If
                End If
            Next i
        End If
        FileClose(filenum)
    End Sub

    Private Sub cooldown_Tick(sender As Object, e As EventArgs) Handles cooldown.Tick
        Enabled = False
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search_id.Click
        info_fill("ID", combo_productID.SelectedItem)
    End Sub

    Private Sub btn_search_desc_Click(sender As Object, e As EventArgs) Handles btn_search_desc.Click
        info_fill("Description", combo_productdesc.SelectedItem)
    End Sub
    Sub refresh_from_current_job()
        list_currentJob.Items.Clear()
        list_currentJob.Items.Add("===========================================================")
        Dim i As New Integer
        ''Create reference between the id and the quantity
        FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
        Dim length_of_product_file As Integer = LOF(1) / Len(job_record)
        Dim running_quantity(length_of_product_file, 2) As String
        If LOF(1) / Len(product_record) = 0 Then
        Else
            For i = 1 To LOF(1) / Len(product_record)
                FileGet(1, product_record, i)
                running_quantity(i - 1, 0) = product_record.product_id
                running_quantity(i - 1, 2) = product_record.product_desc
                'MsgBox(running_quantity(i - 1, 0, 0))
            Next i
        End If
        FileClose(1)
        '' NOW AN ARRAY OF ID'S HAS BEEN SET UP, NOW CYCLE CURRENT JOB AND ADD THE QUANTITYS UPPPPPPPPP
        Dim b As New Integer
        ''Create reference between the id and the quantity
        Dim free_file = FreeFile()
        FileOpen(free_file, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
        If LOF(free_file) / Len(current_job_record) = 0 Then
            list_currentJob.Items.Add("No Records")
        Else
            For b = 1 To LOF(free_file) / Len(current_job_record)
                FileGet(free_file, current_job_record, b)
                Dim x As New Integer
                For x = 0 To (running_quantity.Length / 3) - 1
                    If running_quantity(x, 0) = current_job_record.product_id Then
                        'the quantity can be added to the table position bellow
                        running_quantity(x, 1) += current_job_record.quantity
                        'MsgBox(running_quantity(x, 0) & ": " & running_quantity(x, 1))
                    End If
                Next x
            Next b
        End If
        FileClose(free_file)
        For m = 0 To (running_quantity.Length / 3) - 1
            If running_quantity(m, 1) = "" Then
                'MsgBox(running_quantity(m, 1))
            Else
                'MsgBox(running_quantity(m, 2))
                list_currentJob.Items.Add(running_quantity(m, 0) & ": " & running_quantity(m, 2) & ": " & running_quantity(m, 1))
                'TODO save the product dsc to show in list box  -  output the litty add To listbox For the product (0, 0, i - 1)
                Dim filenum = FreeFile()
                Dim components_required As New List(Of String)
                Dim components_required_quantity As New List(Of String)
                Dim search_parameter As String = running_quantity(m, 0)
                'this needs to be the product id, nest this lot inside a loop thats surrounded by searching current job for all the products and adding the quantitys ^^^
                FileOpen(filenum, "ProductComponent.dat", OpenMode.Random, , , Len(product_component_record))
                If LOF(filenum) / Len(product_component_record) = 0 Then
                Else
                    For i = 1 To LOF(filenum) / Len(product_component_record)
                        FileGet(filenum, product_component_record, i)
                        If product_component_record.product_id = search_parameter Then
                            components_required.Add(product_component_record.component_id)
                        End If
                    Next i
                End If
                FileClose(filenum)
                ''''''''''''''''''''
                Dim component_filenum = FreeFile()
                For x = 1 To components_required.Count
                    Dim component_search_parameter As String = components_required(x - 1)
                    Dim k As Integer
                    FileOpen(component_filenum, "Components.dat", OpenMode.Random, , , Len(component_record))
                    If LOF(component_filenum) / Len(component_record) = 0 Then
                    Else
                        For k = 1 To LOF(component_filenum) / Len(component_record)
                            FileGet(component_filenum, component_record, k)
                            If component_record.component_id = component_search_parameter Then
                                list_currentJob.Items.Add("       " & component_record.component_desc)
                            End If
                        Next k
                    End If
                    FileClose(component_filenum)
                Next x
                '''''''''''''''''''
            End If
            list_currentJob.Items.Add("===========================================================")
        Next m
        Dim duplicates As Boolean = True
        Dim problem As Boolean = False
        While duplicates
            For r = 0 To list_currentJob.Items.Count - 2
                Try
                    problem = False
                    'MsgBox(list_currentJob.Items.Item(r) & ": " & list_currentJob.Items.Item(r + 1))
                    If list_currentJob.Items.Item(r) = list_currentJob.Items.Item(r + 1) Then
                        list_currentJob.Items.RemoveAt(r + 1)
                        problem = True
                        Exit For
                    End If
                Catch
                    duplicates = False
                End Try
            Next
            If problem = False Then
                duplicates = False
            End If
        End While
        update_menu()
    End Sub

    Private Sub btn_addToJob_Click(sender As Object, e As EventArgs) Handles btn_addToJob.Click
        'list_currentJob.Items.Add(combo_productdesc.Text & ": " & combo_quantity.Text)
        ''''''''''''''''''''
        Dim avalible_filenumber = FreeFile()
        FileOpen(avalible_filenumber, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
        Dim lof_current_job As Integer = LOF(avalible_filenumber) / Len(current_job_record)
        current_job_record.item_id = lof_current_job + 1
        current_job_record.product_id = CInt(combo_productID.Text)
        current_job_record.quantity = CInt(combo_quantity.Text)
        FilePut(avalible_filenumber, current_job_record, lof_current_job + 1)
        FileClose(avalible_filenumber)
        'item has been added. now there must be a refresh
        refresh_from_current_job()
    End Sub

    Private Sub ProductComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductComponentToolStripMenuItem.Click
        frmRecordEdit_ProductComponent.Show()
    End Sub

    Private Sub FormatAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatAllToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to format all records? Selecting yes will result in the loss of all data.", "Format - All", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\Products.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\Components.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\Locations.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\Jobs.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\JobProduct.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\LocationComponent.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\ProductComponent.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            Catch
            End Try
        ElseIf result = DialogResult.No Then
            MsgBox("Format Aborted.")
        End If
        refresh_from_current_job()
    End Sub

    Private Sub ResetAllProgramCacheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetAllProgramCacheToolStripMenuItem.Click
        If MsgBox("Are You Sure You Want To Continue?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Reset Program Cache") = Windows.Forms.DialogResult.Yes Then
            End

            Try
                My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            Catch
            End Try
            combo_productdesc.Text = ""
            combo_productID.Text = ""
            combo_quantity.Text = ""
            TextBox4.Clear()
            refresh_from_current_job()
        End If
    End Sub

    Private Sub btn_Clear_Current_Job_Click(sender As Object, e As EventArgs) Handles btn_Clear_Current_Job.Click
        Try
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
        Catch
        End Try
        refresh_from_current_job()
    End Sub

    Private Sub btnConfirmJob_Click(sender As Object, e As EventArgs) Handles btnConfirmJob.Click
        Dim Job_Name As String = InputBox("Enter Desired Job Name.", "Job Name:", "")
        If Job_Name = "" Then
            MessageBox.Show("You Must Enter a Job Name to Continue.")
            Exit Sub
        Else
            'add list of job names'
            Dim list_job_names As New List(Of String)
            FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
            If LOF(1) / Len(job_record) = 0 Then
            Else
                For i = 1 To LOF(1) / Len(job_record)
                    FileGet(1, job_record, i)
                    list_job_names.Add(job_record.job_name.TrimEnd(" "))
                Next i
            End If
            FileClose(1)
            ''
            If list_job_names.Contains(Job_Name) Then 'known as a current job name
                Dim result As Integer = MessageBox.Show("Warning: A Job Has Been Created Under This Name Before; If This Was Intentional Then Please Continue But Proceeding Will Overwrite Any Differences In Products Within The Job." & vbNewLine & "Would You Like To Continue?", "", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    'fuck shit up
                    'find it and add a count
                    Dim o As Integer
                    Dim filenum = FreeFile()
                    FileOpen(filenum, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                    '
                    Dim filenum_temp = FreeFile()
                    FileOpen(filenum_temp, "Jobs_temp.dat", OpenMode.Random, , , Len(job_record))
                    '
                    Dim lof_product_component_temp As Integer = 1
                    '
                    Dim search_parameter As String = Job_Name
                    If LOF(filenum) / Len(job_record) = 0 Then
                    Else
                        For o = 1 To LOF(filenum) / Len(job_record)
                            FileGet(filenum, job_record, o)
                            If job_record.job_name.TrimEnd(" ") = search_parameter Then
                                'MsgBox("OLD COUNT: " & job_record.job_count & "FOR: " & job_record.job_name)
                                job_record.job_count = job_record.job_count + 1
                                FilePut(filenum_temp, job_record, lof_product_component_temp)
                                'MsgBox("NEW COUNT: " & job_record.job_count & "FOR: " & job_record.job_name)
                            Else
                                FilePut(filenum_temp, job_record, lof_product_component_temp)
                            End If
                            lof_product_component_temp += 1
                        Next o
                    End If
                    FileClose(filenum)
                    FileClose(filenum_temp)
                    My.Computer.FileSystem.DeleteFile(CurDir() & "\Jobs.dat")
                    My.Computer.FileSystem.RenameFile(CurDir() & "\Jobs_temp.dat", "Jobs.dat")
                    'TODO make it check that the products in the job are the same
                    '
                    MessageBox.Show("Job Information Successfully Updated.", "", MessageBoxButtons.OK)
                ElseIf result = DialogResult.No Then
                End If
            Else
                FileOpen(1, "Jobs.dat", OpenMode.Random, , , Len(job_record))
                Dim lof_job As Integer = LOF(1) / Len(job_record)
                job_record.job_id = lof_job + 1
                job_record.job_name = Job_Name
                Dim current_time As DateTime = DateTime.Now
                job_record.job_date_created = DateTime.Now.ToString("dd/MM/yyyy")
                job_record.job_count = 1
                Dim result As Integer = MessageBox.Show("Would You Like To Pin This Job?", "", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    job_record.job_pinned = True
                ElseIf result = DialogResult.No Then
                    job_record.job_pinned = False
                End If
                job_record.job_username = Environment.UserName
                FilePut(1, job_record, lof_job + 1)
                FileClose(1)
                MessageBox.Show("The Job Has Been Added.")
                'not known as a job currently and needs
                'ABOUT TO SET UP CURRENT JOB STUFF
                Dim i As New Integer
                ''Create reference between the id and the quantity
                FileOpen(1, "Products.dat", OpenMode.Random, , , Len(product_record))
                Dim length_of_product_file As Integer = LOF(1) / Len(job_record)
                Dim running_quantity(length_of_product_file, 2) As String
                If LOF(1) / Len(product_record) = 0 Then
                Else
                    For i = 1 To LOF(1) / Len(product_record)
                        FileGet(1, product_record, i)
                        running_quantity(i - 1, 0) = product_record.product_id
                        running_quantity(i - 1, 2) = product_record.product_desc
                        'MsgBox(running_quantity(i - 1, 0, 0))
                    Next i
                End If
                FileClose(1)
                '' NOW AN ARRAY OF ID'S HAS BEEN SET UP, NOW CYCLE CURRENT JOB AND ADD THE QUANTITYS UPPPPPPPPP
                Dim b As New Integer
                ''Create reference between the id and the quantity
                Dim free_file = FreeFile()
                FileOpen(free_file, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
                If LOF(free_file) / Len(current_job_record) = 0 Then
                Else
                    For b = 1 To LOF(free_file) / Len(current_job_record)
                        FileGet(free_file, current_job_record, b)
                        Dim x As New Integer
                        For x = 0 To (running_quantity.Length / 3) - 1
                            If running_quantity(x, 0) = current_job_record.product_id Then
                                'the quantity can be added to the table position bellow
                                running_quantity(x, 1) += current_job_record.quantity
                                'MsgBox(running_quantity(x, 0) & ": " & running_quantity(x, 1))
                            End If
                        Next x
                    Next b
                End If
                FileClose(free_file)
                'NOW NEED TO ADD TO PRODUCT_JOB
                For p = 0 To (running_quantity.Length / 3) - 1
                    MsgBox(running_quantity(p, 1))
                    If running_quantity(p, 1) <> "" Or running_quantity(p, 1) <> 0 Then
                        FileOpen(1, "JobProduct.dat", OpenMode.Random, , , Len(job_product_record))
                        Dim lof_product_component As Integer = LOF(1) / Len(job_product_record)
                        'Dim product_id As Integer 'FK 'Automatically generated
                        'Dim component_id As Integer 'FK 'Automatically generated
                        'Dim quantity As Integer ' Combo box
                        job_product_record.job_id = lof_job + 1
                        job_product_record.product_id = running_quantity(p, 0)
                        job_product_record.quantity = running_quantity(p, 1)
                        FilePut(1, job_product_record, lof_product_component + 1)
                        FileClose(1)
                    End If
                Next
                Try
                    My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
                Catch
                End Try
            End If
            'cycle through all products in the job and add their components and quantitys and locations to the table (print_components)
            'open print dialouge
            'remember to hide it :)
            'labelPrint.Print()
            'Print_Components.Rows.Add("Test", "Test", "5")
            '''''



            '''''
        End If
        refresh_from_current_job()
        PrintLabels.Show()
    End Sub

    Private Sub btnRemoveFromJob_Click(sender As Object, e As EventArgs) Handles btnRemoveFromJob.Click
        If list_currentJob.GetItemText(list_currentJob.SelectedItem).Contains(": ") Then
            Dim array_selected_item() As String = Regex.Split(list_currentJob.GetItemText(list_currentJob.SelectedItem), ": ")
            Dim current_job_file = FreeFile()
            Dim temp_current_job_file = FreeFile() + 1
            '
            File.Create("CurrentJob_temp.dat").Dispose()
            '
            Dim job_LOF_temp As Integer = 1
            FileOpen(current_job_file, "CurrentJob.dat", OpenMode.Random, , , Len(current_job_record))
            FileOpen(temp_current_job_file, "CurrentJob_temp.dat", OpenMode.Random, , , Len(current_job_record))
            If LOF(current_job_file) / Len(current_job_record) = 0 Then
            Else
                For i = 1 To LOF(current_job_file) / Len(current_job_record)
                    FileGet(current_job_file, current_job_record, i)
                    If current_job_record.product_id = array_selected_item(0) Then 'TODO Product ID
                    Else
                        FilePut(temp_current_job_file, current_job_record, job_LOF_temp)
                    End If
                    job_LOF_temp += 1
                Next i
            End If
            FileClose(current_job_file)
            FileClose(temp_current_job_file)
            '
            My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
            My.Computer.FileSystem.RenameFile(CurDir() & "\CurrentJob_temp.dat", "CurrentJob.dat")
            refresh_from_current_job()
            ''''''''''''''''''''''
        Else 'is a selected product
            MsgBox("Please select a product.")
        End If
    End Sub

    Private Sub JobProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobProductToolStripMenuItem.Click
        frmRecordEdit_JobProduct.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Print_Components.CellContentClick

    End Sub

    Private Sub ExportAsBackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportAsBackupToolStripMenuItem.Click
        If (Not System.IO.Directory.Exists(CurDir() & "\Temp")) Then
            System.IO.Directory.CreateDirectory(CurDir() & "\Temp")
        End If
        Try
            File.Copy(CurDir() & "\Jobs.dat", CurDir() & "\Temp\Jobs.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\JobProduct.dat", CurDir() & "\Temp\JobProduct.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\Products.dat", CurDir() & "\Temp\Products.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\CurrentJob.dat", CurDir() & "\Temp\CurrentJob.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\ProductComponent.dat", CurDir() & "\Temp\ProductComponent.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\Components.dat", CurDir() & "\Temp\Components.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\Locations.dat", CurDir() & "\Temp\Locations.dat")
        Catch
        End Try
        Try
            File.Copy(CurDir() & "\ComponentLocation.dat", CurDir() & "\Temp\ComponentLocation.dat")
        Catch
        End Try
        ZipFile.CreateFromDirectory(CurDir() & "\Temp\", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\EMU-Archive_" & DateTime.Now.DayOfYear & ".zip", CompressionLevel.Optimal, False)
        Dim path As String = CurDir() & "\Temp\"
        System.IO.Directory.Delete(path, True)
        MessageBox.Show("Archive Has Been Created. It Can Be Found On Your Desktop Under:" & vbNewLine & "'" & Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\EMU-Archive_" & DateTime.Now.DayOfYear & ".zip" & "'.", "Archive Has Been Created.", MessageBoxButtons.OK)
    End Sub

    Private Sub ImportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportToolStripMenuItem.Click
        If (importRecords.ShowDialog = Windows.Forms.DialogResult.OK) Then
            If Path.GetExtension(importRecords.FileName) = ".zip" Then
                Dim result As String = MessageBox.Show("File Selected Successfully." & vbNewLine & vbNewLine & importRecords.FileName & vbNewLine & vbNewLine & "By Pressing Okay You Are Acknowledging That Any Current Data Will Be Overwritten.", "Incorrent File Extension.", MessageBoxButtons.YesNo)
                If result = DialogResult.No Then
                    MessageBox.Show("Import Aborted", "", MessageBoxButtons.OK)
                Else
                    'delete all old files and extract to new
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\Products.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\Components.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\Locations.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\Jobs.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\JobProduct.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\LocationComponent.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\ProductComponent.dat")
                    Catch
                    End Try
                    Try
                        My.Computer.FileSystem.DeleteFile(CurDir() & "\CurrentJob.dat")
                    Catch
                    End Try
                    MsgBox("Previous Files Removed.")
                    ZipFile.ExtractToDirectory(importRecords.FileName, CurDir())
                    MsgBox("New Files Added.")
                    refresh_from_current_job()
                End If
            Else
                MessageBox.Show("Please Select A Zip File.", "Incorrent File Extension.", MessageBoxButtons.OK)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub SaveCurrentSessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveCurrentSessionToolStripMenuItem.Click
        MsgBox("Session Saved.")
    End Sub

End Class


