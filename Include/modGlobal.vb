Imports FieldSoftware.PrinterCE_NetCF
Module modGlobal

    Public publicUserID As String
    Public publicUserName As String
    Public publicReturnCode As String
    Public publicReturnDesc As String
    Public publicProject As String = "eWMS Mobile"
    Public publicMobileVersion As String = "2018.01.00.0"
    Public publicCurrentCountry As String = ""
    Public wsPath As String
    Public sSelectedProduct As String = ""
    Public sSelectedDescription As String = ""

    Public Function FillDomainCombo(ByVal e As ComboBox, ByVal pDomain As String, ByVal ColValue As String, _
                                        ByVal ColText As String, Optional ByVal pDomainValue As String = "")
        Dim xcommon As New wsCommonServices.wsCommonServices
        Dim xdataset As DataSet, i As Long

        Dim sSQL As String
        If pDomainValue = "" Then
            sSQL = "SELECT * from DEF_DOMAINS where domain = '" + pDomain.Trim.ToUpper + "' Order By DomainValue"
        Else
            sSQL = "SELECT * from DEF_DOMAINS where domain = '" + pDomain.Trim.ToUpper + "' and DOMAINVALUE = '" + pDomainValue.Trim.ToUpper + "' Order by DomainValue"
        End If

        xdataset = xcommon.GetDataSet(sSQL)
        e.DataSource = xdataset.Tables("myTable")
        e.DisplayMember = ColText
        e.ValueMember = ColValue

        Try
            e.SelectedIndex = 0
        Catch ex As Exception

        End Try

    End Function

    Public Function mSGeRRORS(ByVal str As String)
        Dim TestPos1 As Integer = InStr(str, "System.Exception: ") + 18
        Dim TestPos2 As Integer = InStr(str, "en Microsoft.VisualBasic") - 2
        Dim TestStr As String = Mid(str, TestPos1, TestPos2 - TestPos1)
        'Return TestStr
        MsgBox(TestStr)
    End Function

    Public Function FormatErrorMessage(ByVal sMessage As String) As String
        Dim xCommon As New wsCommonServices.wsCommonServices

        Try
            Return xCommon.FormatErrorMessage(sMessage)
        Catch ex As Exception
            Return sMessage
        End Try

    End Function

    Public Function FillDataCombo(ByVal e As ComboBox, ByVal sSQL As String, ByVal ColText As String, ByVal ColValue As String)
        Dim xcommon As New wsCommonServices.wsCommonServices
        Dim xdataset As DataSet, i As Long
        Dim myRow As DataRow

        xdataset = xcommon.GetDataSet(sSQL)
        e.DataSource = xdataset.Tables("myTable")
        e.DisplayMember = ColText
        e.ValueMember = ColValue

    End Function


    <System.Runtime.InteropServices.DllImport("CoreDll.DLL")> _
    Private Function CreateProcess( _
        ByVal imageName As String, _
        ByVal cmdLine As String, _
        ByVal lpProcessAttributes As Integer, _
        ByVal lpThreadAttributes As Integer, _
        ByVal boolInheritHandles As Int32, _
        ByVal dwCreationFlags As Int32, _
        ByVal lpEnvironment As Integer, _
        ByVal lpszCurrentDir As Integer, _
        ByVal si As Integer, _
        ByVal pi As Integer) As Integer
    End Function




    Public Sub Execute(ByVal exeName As String)
        CreateProcess(exeName, "", 0, 0, 0, 0, 0, 0, 0, 0)
    End Sub

    Public Sub BPrint(ByVal txtPrinterText As String)
        'se crea el objeto y se coloca la licencia...
        Dim Directo As New AsciiCE("737S1K397A")
        Try
            'asignamos el puerto a utilizar
            Directo.SelectPort(AsciiCE.ASCIIPORT.COM9)
            Directo.Text(txtPrinterText)
            Directo.CrLf()
            Directo.CrLf()
            Directo.CrLf()
            Directo.ClosePort()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error")
            Directo.ShutDown()
        Finally
            Directo.ShutDown()
            Directo = Nothing
        End Try
    End Sub

    Public Function PrintLocalManifestLabel(ByVal strPrefix As String, ByVal strDA As String, ByVal strBL As String, ByVal strConsignee As String, ByVal strContainer As String, ByVal strAgent As String, ByVal strDateEntered As String, ByVal strNPackages As String, ByVal strPackages As String, ByVal strBLShort As String, ByVal strCompany As String, ByVal strDAlabel As String, ByVal strNoResa As String) As String
        'Imprime la etiqueta localmente
        Dim txtTextoImpresora As String

        If strCompany = "" Then
            strCompany = "AIMAR, S.A."
        End If
        If strDAlabel = "" Then
            strDAlabel = "D.A."
        End If

        txtTextoImpresora = "! 0 200 200 610 1 " & vbCrLf & _
                "TEXT 5 0 40 50 " & strDAlabel & ":" & vbCrLf & _
                "TEXT 5 0 250 50  " & strPrefix & "-" & strDA & vbCrLf & _
                "TEXT 5 0 40 100 Consignatario:  " & vbCrLf & _
                "TEXT 5 0 250 100 " & strConsignee & vbCrLf & _
                "TEXT 5 0 40 150 Contenedor:     " & vbCrLf & _
                "TEXT 5 0 250 150 " & strContainer & vbCrLf & _
                "TEXT 5 0 550 150 # Resa: " & strNoResa & vbCrLf & _
                "TEXT 5 0 40 200 Agente:         " & vbCrLf & _
                "TEXT 5 0 250 200 " & strAgent & vbCrLf & _
                "TEXT 5 0 40 250 Fecha Ingreso:  " & vbCrLf & _
                "TEXT 5 0 250 250 " & strDateEntered & vbCrLf & _
                "TEXT 5 0 560 250 Bultos:         " & vbCrLf & _
                "TEXT 5 0 650 250 " & strNPackages & "/" & strPackages & vbCrLf

        If strBLShort = "" Then
            txtTextoImpresora = txtTextoImpresora & "BARCODE 128 2 2 200 25 310 " & strPrefix & "-" & strDA & "||" & strBL & vbCrLf
        Else
            txtTextoImpresora = txtTextoImpresora & "TEXT 5 0 40 520 " & strPrefix & "-" & strDA & "||" & strBLShort & vbCrLf
            txtTextoImpresora = txtTextoImpresora & "BARCODE 128 2 2 200 25 310 " & strPrefix & "-" & strDA & "||" & strBLShort & vbCrLf
        End If
        txtTextoImpresora = txtTextoImpresora & "TEXT 5 0 375 520 " & strPrefix & "-" & strDA & "||" & strBL & vbCrLf

        txtTextoImpresora = txtTextoImpresora & "TEXT 4 0 300 550 " & strCompany & vbCrLf & _
                "FORM" & vbCrLf & _
                "PRINT"

        Try
            BPrint(txtTextoImpresora)
            PrintLocalManifestLabel = "Impresion exitosa"

        Catch ex As Exception
            PrintLocalManifestLabel = ex.Message

        End Try





    End Function

    Public Function PrintLocalCFSLabel(ByVal theViajeId As String, ByVal theViajeIdDetail As String, ByVal theDetail As String, ByVal theCustomer As String, ByVal theFabrica As String, ByVal theConsignee As String, ByVal strDateEntered As String, ByVal strNPackages As String, ByVal strPackages As String, ByVal strCompany As String) As String
        'Imprime la etiqueta localmente
        Dim txtTextoImpresora As String
        Dim xcommon As New wsCommonServices.wsCommonServices

        If strCompany = "" Then
            strCompany = "AIMAR, S.A."
        End If

        '        txtTextoImpresora = "! 0 200 200 610 1 " & vbCrLf & _
        '"TEXT 5 0 40 50 D.A.:" & vbCrLf & _
        '"TEXT 5 0 250 50  " & strPrefix & "-" & strDA & vbCrLf & _
        '"TEXT 5 0 40 100 Consignatario:  " & vbCrLf & _
        '"TEXT 5 0 250 100 " & strConsignee & vbCrLf & _
        '"TEXT 5 0 40 150 Contenedor:     " & vbCrLf & _
        '"TEXT 5 0 250 150 " & strContainer & vbCrLf & _
        '"TEXT 5 0 40 200 Agente:         " & vbCrLf & _
        '"TEXT 5 0 250 200 " & strAgent & vbCrLf & _
        '"TEXT 5 0 40 250 Fecha Ingreso:  " & vbCrLf & _
        '"TEXT 5 0 250 250 " & strDateEntered & vbCrLf & _
        '"TEXT 5 0 560 250 Bultos:         " & vbCrLf & _
        '"TEXT 5 0 650 250 " & strNPackages & "/" & strPackages & vbCrLf & _
        '"BARCODE 128 2 2 200 25 310 " & strPrefix & "-" & strDA & "||" & strBL & vbCrLf & _
        '"TEXT 4 0 300 550 Aimar S.A." & vbCrLf & _
        '"FORM" & vbCrLf & _
        '"PRINT"

        If strDateEntered = "NOW" Then
            strDateEntered = xcommon.GetCurrentDate
        End If

        txtTextoImpresora = "! 0 200 200 610 1 " & vbCrLf
        'txtTextoImpresora = "! 0 200 200 310 1 " & vbCrLf

        txtTextoImpresora = txtTextoImpresora & "TEXT 5 0 40 50 Numero Viaje:" & vbCrLf & _
        "TEXT 5 0 250 50  " & theViajeId & vbCrLf & _
        "TEXT 5 0 350 50  " & theDetail & vbCrLf & _
        "TEXT 5 0 40 100 Cliente:  " & vbCrLf & _
        "TEXT 5 0 250 100 " & theCustomer & vbCrLf & _
        "TEXT 5 0 40 150 Fabrica:     " & vbCrLf & _
        "TEXT 5 0 250 150 " & theFabrica & vbCrLf & _
        "TEXT 5 0 40 200 Consignatario:         " & vbCrLf & _
        "TEXT 5 0 250 200 " & theConsignee & vbCrLf & _
        "TEXT 5 0 40 250 Fecha de Ingreso:  " & vbCrLf & _
        "TEXT 5 0 250 250 " & strDateEntered & vbCrLf & _
        "TEXT 5 0 560 250 Items:         " & vbCrLf
        '"TEXT 5 0 650 250 " & strNPackages & "/" & strPackages & vbCrLf & _
        txtTextoImpresora = txtTextoImpresora & _
        "TEXT 5 0 650 250 " & strPackages & vbCrLf & _
        "BARCODE 128 2 2 200 25 310 CFS||" & theViajeId & "||" & theViajeIdDetail & vbCrLf & _
        "TEXT 4 0 300 550 " & strCompany & vbCrLf & _
        "FORM" + vbCrLf + _
        "PRINT"

        '        txtTextoImpresora = "! 0 200 200 610 1 " + vbCrLf + _
        ' "TEXT 5 0 40 50 Numero Viaje:" + vbCrLf + _
        ' "TEXT 5 0 250 50  " & theViajeId & vbCrLf & _
        ' "TEXT 5 0 350 50  " & theDetail & vbCrLf & _
        ' "TEXT 5 0 40 100 Cliente:  " + vbCrLf + _
        '"TEXT 5 0 250 100 " & theCustomer & vbCrLf & _
        ' "TEXT 5 0 40 150 Fabrica:     " + vbCrLf + _
        ' "TEXT 5 0 250 150 " & theFabrica & vbCrLf & _
        ' "TEXT 5 0 40 200 Consignatario:         " + vbCrLf + _
        ' "TEXT 5 0 250 200 " & theConsignee & vbCrLf & _
        ' "TEXT 5 0 40 250 Fecha de Ingreso:  " + vbCrLf + _
        ' "TEXT 5 0 250 250 " & strDateEntered & vbCrLf & _
        ' "TEXT 5 0 560 250 Bultos:         " + vbCrLf + _
        ' "TEXT 5 0 650 250 " & strNPackages & "/" & strPackages & vbCrLf & _
        ' "BARCODE 128 2 2 200 25 310 CFS||" & theViajeId & "||" & theViajeIdDetail & vbCrLf & _
        ' "TEXT 4 0 300 550 Aimar S.A." + vbCrLf + _
        ' "FORM" + vbCrLf + _
        ' "PRINT"


        Try
            BPrint(txtTextoImpresora)
            PrintLocalCFSLabel = "Impresion exitosa"

        Catch ex As Exception
            PrintLocalCFSLabel = ex.Message

        End Try





    End Function



End Module

