Option Strict Off
Option Explicit On
Friend Class frmimportar
	Inherits System.Windows.Forms.Form
	Dim regprogram As Short
	Dim TXT As Registro
	Dim NRegistros As Integer
	
	Private Sub botimportar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botimportar.Click
		NRegistros = 0
		bd.Refresh()
		
		Dim Respuesta, Ayuda, Estilo, Mensaje, Título, Ctxt, MiCadena As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mensaje. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mensaje = "¿Desea continuar?"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Estilo = MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Título = "Añadir Registros a Base De Datos"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'context' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'helpfile' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Respuesta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Respuesta = MsgBox(Mensaje, Estilo, Título)
		
		If Respuesta = MsgBoxResult.Yes Then
			dialogoOpen.ShowDialog()
			If dialogoOpen.FileName = "" Then Exit Sub
			
			FileOpen(1, dialogoOpen.FileName, OpenMode.Binary) ' 1º Abre
			'UPGRADE_WARNING: Get se actualizó a FileGet y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(1, regprogram)
			FileClose(1) ' 1º Cierra
			
			If regprogram = 7980 Then
				MsgBox("Clave de archivo de Seguridad Valida. Se procede a la carga . . .")
				Call descargar(1)
				FileClose()
				Exit Sub
			Else
				MsgBox("Archivo no válido, clave de seguridad incorrecta o acción cancelada")
			End If
		Else
			MsgBox("Accion Cancelada", MsgBoxStyle.Information)
		End If
		Me.Close()
		frmFrecuencias.Show()
		
	End Sub
	
	Sub descargar(ByRef Tipo As Byte)
		Dim reg As Object
		On Error Resume Next
		' Tipo = 0 Cargar
		' Tipo = 1 Añadir
		
		bd.Refresh()
		
		Select Case Tipo
			Case 0
				opttodos.Checked = True
				FileOpen(1, dialogoOpen.FileName, OpenMode.Binary)
				'UPGRADE_WARNING: Get se actualizó a FileGet y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FileGet(1, regprogram)
				FileClose()
			Case 1
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.MoveLast()
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				If Not bd.Recordset("Registro") Then
					'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					reg = CShort(bd.Recordset("Registro"))
				Else
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					reg = 0
				End If
				
				FileOpen(1, dialogoOpen.FileName, OpenMode.Binary)
				'UPGRADE_WARNING: Get se actualizó a FileGet y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FileGet(1, regprogram)
				FileClose()
		End Select
		
		If opttodos.Checked = True Then
			Call Importar(0) ' Importar Todos
		End If
		
		If optseleccionar.Checked = True Then
			If chkcomprob.CheckState = 1 And chkexport.CheckState = 0 Then
				Call Importar(1) ' Solo Los Comprobados
			End If
			If chkcomprob.CheckState = 0 And chkexport.CheckState = 1 Then
				Call Importar(2) ' Solo los Exportables
			End If
			If chkcomprob.CheckState = 1 And chkexport.CheckState = 1 Then
				Call Importar(3) ' Todos los Comprobados y Exportables
			Else
				MsgBox("Seleccione alguna opcion", MsgBoxStyle.Information)
			End If
		End If
		
		FileClose(1)
		
		
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.MoveLast()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Delete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.Delete()
		
		MsgBox("Importación realizada con éxito", MsgBoxStyle.Information)
		
		
		Me.Close()
		frmFrecuencias.Show()
	End Sub
	
	Sub Importar(ByRef Condicion As Byte)
		FileClose()
		FileOpen(1, dialogoOpen.FileName, OpenMode.Binary)
		'UPGRADE_WARNING: Get se actualizó a FileGet y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FileGet(1, regprogram)
		
		Do 
			'UPGRADE_WARNING: Get se actualizó a FileGet y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FileGet(1, TXT)
			If TXT.Observaciones = "FIN" Then Exit Sub
			
			NRegistros = NRegistros + 1
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.AddNew. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.AddNew()
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Registro")) = NRegistros
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Fecha")) = TXT.Fecha
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Frecuencia")) = Trim(TXT.Frecuencia)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Memoria")) = TXT.MEMORIA
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Localidad")) = Trim(TXT.Localidad)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Observaciones")) = Trim(TXT.Observaciones)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Banda")) = Trim(TXT.Banda)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Comprobado")) = TXT.Comprobado
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Exportar")) = TXT.Exportar
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.Update()
			
		Loop While Not EOF(1)
		
	End Sub
End Class