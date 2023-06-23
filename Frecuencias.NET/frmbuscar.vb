Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmbuscar
	Inherits System.Windows.Forms.Form
	Dim frecu As Decimal
	Dim cadenabusqueda As String
	Dim cadena As String
	
	
	
	Private Sub botbusca_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botbusca.Click
		Dim frecuenciabuscada As Object
		Dim longit As Object
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		Dim cadenacomprobado As Object
		Dim cadenabanda As Object
		Dim cadenaobservaciones As Object
		Dim cadenafecha As Object
		Dim fech As Object
		Dim Valor As Object
		Dim cadenalocalidad As Object
		Dim loca As Object
		Dim ban As Object
		Dim cadenamemoria As Object
		Dim mem As Object
		Dim Dato As Object
		Dim cadenafrecuencia As Object
		Dim khz As Object
		Dim mhz As Object
		Dim punto As Object
		Dim Frec As Object
		cadenabusqueda = ""
		bd.Refresh()
		
		' Frecuencia
		If chkFrecuencia.CheckState = 1 Or chkFrecuencia.CheckState = 2 Then
			
			If VB.Right(txtFrecuencia.Text, 1) = "M" Or VB.Right(txtFrecuencia.Text, 1) = "m" Or VB.Right(txtFrecuencia.Text, 1) = "K" Or VB.Right(txtFrecuencia.Text, 1) = "k" Then GoTo Frecuencia2
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Frec = Frecuencia
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			punto = InStr(Frec, ".")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			mhz = VB.Left(Frec, punto - 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			khz = Mid(Frec, punto + 1)
			
			If IsNumeric(mhz) = True And IsNumeric(khz) = True Then
				If Len(Frec) > 0 Then
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafrecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cadenafrecuencia = "Frecuencia=" & Chr(39) + Frec + Chr(39)
				Else
					Call FALLO()
				End If
			Else
				Call FALLO()
			End If
		End If
		
		
		' Frecuencia, Busqueda por MHZ o por KHZ
		
Frecuencia2: 
		If chkFrecuencia.CheckState = 1 Or chkFrecuencia.CheckState = 2 Then
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Frec = Frecuencia
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Dato. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Dato = UCase(VB.Right(txtFrecuencia.Text, 1))
			
			Select Case Dato
				
				Case "M"
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Frec = Mid(txtFrecuencia.Text, 1, Len(txtFrecuencia.Text) - 1)
					If Len(Frec) <= 0 Then Call FALLO()
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafrecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cadenafrecuencia = "Mhz=" & Chr(39) + Frec + Chr(39)
					
				Case "K"
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Frec = Mid(txtFrecuencia.Text, 1, Len(txtFrecuencia.Text) - 1)
					If Len(Frec) <= 0 Then Call FALLO()
					
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafrecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cadenafrecuencia = "Khz=" & Chr(39) + Frec + Chr(39)
			End Select
			
		End If
		
		' Memoria
		If chkmemoria.CheckState = 1 Then
			If TxtMemoria.Text = "" Then
				MsgBox("No ha Introducido ningún valor", MsgBoxStyle.Critical)
				Call borrar()
				cadenabusqueda = "FALLO"
				Exit Sub
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mem = TxtMemoria.Text
				If IsNumeric(TxtMemoria.Text) = True Then
					
					If Len(mem) > 0 Then
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If CShort(mem) >= 0 And CShort(mem) <= 50 Then
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenamemoria. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							cadenamemoria = "Memoria=" + mem
						Else
							MsgBox("El Escaner Solo tiene 50 Memorias o la Auxiliar 0", MsgBoxStyle.Information)
							cadenabusqueda = "FALLO"
							Exit Sub
						End If
					Else
						Call FALLO()
					End If
				End If
			End If
		End If
		
		If chkmemoria.CheckState = 2 Then ' Busca todas las Memorias Almacenadas
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ban. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ban = Chr(39) & Chr(39)
			cadenabusqueda = "Memoria > 0 and Memoria < 51"
		End If
		
		'Localidad
		If chklocalidad.CheckState = 1 Or chklocalidad.CheckState = 2 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto loca. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			loca = TxtLocalidad.Text
			If Len(loca) > 0 Then
				Select Case chklocalidad.CheckState
					Case 1
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto loca. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenalocalidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						cadenalocalidad = "Localidad=" & Chr(39) + loca + Chr(39)
					Case 2
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto loca. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenalocalidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						cadenalocalidad = "Localidad<>" & Chr(39) + loca + Chr(39)
				End Select
			Else
				Call FALLO()
			End If
		End If
		
		' Fecha
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Valor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Valor = chkfecha.CheckState
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Valor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Valor = 1 Or Valor = 2 Then
			If IsDate(txtfecha.Text) = True Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fech. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				fech = CStr(CSng(CDate(txtfecha.Text).ToOADate))
				If Len(fech) > 0 Then
					Select Case Valor
						Case 1
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fech. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafecha. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							cadenafecha = "Fecha=" + fech
						Case 2
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fech. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafecha. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							cadenafecha = "Fecha<>" + fech
					End Select
				Else
					MsgBox("Teclee una Fecha Válida", MsgBoxStyle.Exclamation)
					Exit Sub
				End If
			Else
				MsgBox("Fecha No Válida", MsgBoxStyle.Information)
				Call FALLO()
			End If
		End If
		
		' Observaciones
		If chkobservaciones.CheckState = 1 Or chkobservaciones.CheckState = 2 Then
			Select Case chkobservaciones.CheckState
				Case 1
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenaobservaciones. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cadenaobservaciones = "Observaciones=" & Chr(39) & txtobservaciones.Text & Chr(39)
				Case 2
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenaobservaciones. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					cadenaobservaciones = "Observaciones<>" & Chr(39) & txtobservaciones.Text & Chr(39)
			End Select
		End If
		
		' Banda
		If chkBanda.CheckState = 1 Or chkBanda.CheckState = 2 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ban. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ban = Chr(39) & TxtBanda.Text & Chr(39)
			If Len(ban) > 0 Then
				Select Case chkBanda.CheckState
					Case 1
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ban. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenabanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						cadenabanda = "Banda=" + ban
					Case 2
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ban. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenabanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						cadenabanda = "Banda<>" + ban
				End Select
			Else
				Call FALLO()
			End If
		End If
		
		'Comprobado
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenacomprobado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If chkcomprobado.CheckState = 1 Then cadenacomprobado = "Comprobado=True"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenacomprobado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If chkcomprobado.CheckState = 2 Then cadenacomprobado = "Comprobado=False"
		If cadenabusqueda <> "FALLO" Then
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafrecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chkFrecuencia.CheckState = 1 Then cadenabusqueda = cadenabusqueda & " and " + cadenafrecuencia
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenamemoria. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chkmemoria.CheckState = 1 Then cadenabusqueda = cadenabusqueda & " and " + cadenamemoria
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenalocalidad. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chklocalidad.CheckState = 1 Or chklocalidad.CheckState = 2 Then cadenabusqueda = cadenabusqueda & " and " + cadenalocalidad
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenafecha. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chkfecha.CheckState = 1 Or chkfecha.CheckState = 2 Then cadenabusqueda = cadenabusqueda & " and " + cadenafecha
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenabanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chkBanda.CheckState = 1 Or chkBanda.CheckState = 2 Then cadenabusqueda = cadenabusqueda & " and " + cadenabanda
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenacomprobado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chkcomprobado.CheckState = 1 Or chkcomprobado.CheckState = 2 Then cadenabusqueda = cadenabusqueda & " and " + cadenacomprobado
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenaobservaciones. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If chkobservaciones.CheckState = 1 Or chkobservaciones.CheckState = 2 Then cadenabusqueda = cadenabusqueda & " and " + cadenaobservaciones
		Else
			VB6.ShowForm(Me, (modal_Renamed))
		End If
		
		cadenabusqueda = Trim(cadenabusqueda)
		
		If VB.Left(cadenabusqueda, 3) = "and" Then
			cadenabusqueda = Mid(cadenabusqueda, 4)
			cadenabusqueda = Trim(cadenabusqueda)
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto longit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		longit = Len(cadenabusqueda)
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto longit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If cadenabusqueda = "FALLO" Or longit = 0 Then Exit Sub
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto longit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If longit > 0 Or cadenabusqueda <> "FALLO" Then
			
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.FindFirst(cadenabusqueda)
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not bd.Recordset.NoMatch Then
				Modulo.grabar((cadenabusqueda))
				Me.Close()
				VB6.ShowForm(frmResultados, (modal_Renamed))
			Else
				MsgBox("No existen coincidencias para la cadena : " & Chr(10) & Chr(13) & cadenabusqueda, MsgBoxStyle.Information)
				Call borrar()
				cadena = VB.Left(cadenabusqueda, 4)
				
				If cadena = "Frec" Then
					
					' Rutina para Averiguar los Posibles Repetidores
					' o frecuencias de desplazamiento
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frecuenciabuscada. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					frecuenciabuscada = VB.Left(VB.Right(cadenabusqueda, 9), 8)
					Modulo.grabarFrec((frecuenciabuscada))
					
					VB6.ShowForm(frmrepetidores, (modal_Renamed))
					frmrepetidores.botguardar.Visible = True
				End If
			End If
			
		Else
			MsgBox("No hay una cadena de busqueda válida", MsgBoxStyle.Critical)
		End If
		
	End Sub
	
	Sub FALLO()
		MsgBox("Introduzca un valor de búsqueda válido", MsgBoxStyle.Critical)
		cadenabusqueda = "FALLO"
		Call borrar()
	End Sub
	
	Private Sub chkcomprobado_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkcomprobado.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Button = 2 Then
			If chkcomprobado.CheckState = 2 Then
				chkcomprobado.CheckState = System.Windows.Forms.CheckState.Unchecked
			Else
				chkcomprobado.CheckState = System.Windows.Forms.CheckState.Indeterminate
			End If
		End If
		
	End Sub
	Private Sub chkLocalidad_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkLocalidad.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Button = 2 Then
			If chklocalidad.CheckState = 2 Then
				chklocalidad.CheckState = System.Windows.Forms.CheckState.Unchecked
			Else
				chklocalidad.CheckState = System.Windows.Forms.CheckState.Indeterminate
			End If
		End If
		
	End Sub
	Private Sub chkbanda_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkbanda.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Button = 2 Then
			If chkBanda.CheckState = 2 Then
				chkBanda.CheckState = System.Windows.Forms.CheckState.Unchecked
			Else
				chkBanda.CheckState = System.Windows.Forms.CheckState.Indeterminate
			End If
		End If
		
	End Sub
	
	
	Private Sub chkfecha_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkfecha.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Button = 2 Then
			If chkfecha.CheckState = 2 Then
				chkfecha.CheckState = System.Windows.Forms.CheckState.Unchecked
			Else
				chkfecha.CheckState = System.Windows.Forms.CheckState.Indeterminate
			End If
		End If
		
	End Sub
	
	Private Sub chkmemoria_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkmemoria.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Button = 2 Then
			If chkmemoria.CheckState = 2 Then
				chkmemoria.CheckState = System.Windows.Forms.CheckState.Unchecked
				TxtMemoria.Enabled = True
				TxtMemoria.BackColor = System.Drawing.Color.White
				'UPGRADE_WARNING: TextBox propiedad TxtMemoria.MaxLength tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				TxtMemoria.Maxlength = 2
				TxtMemoria.Text = ""
			Else
				chkmemoria.CheckState = System.Windows.Forms.CheckState.Indeterminate
				TxtMemoria.Enabled = False
				TxtMemoria.BackColor = System.Drawing.ColorTranslator.FromOle(&H8000000F)
				'UPGRADE_WARNING: TextBox propiedad TxtMemoria.MaxLength tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				TxtMemoria.Maxlength = 5
				TxtMemoria.Text = "Todas"
			End If
		End If
		
		If Button = 1 Then
			TxtMemoria.Enabled = True
			TxtMemoria.BackColor = System.Drawing.Color.White
		End If
		
	End Sub
	
	Private Sub chkobservaciones_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles chkobservaciones.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		
		If Button = 2 Then
			If chkobservaciones.CheckState = 2 Then
				chkobservaciones.CheckState = System.Windows.Forms.CheckState.Unchecked
			Else
				chkobservaciones.CheckState = System.Windows.Forms.CheckState.Indeterminate
			End If
		End If
		
	End Sub
	
	'UPGRADE_WARNING: El evento TxtBanda.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxtBanda_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtBanda.SelectedIndexChanged
		If chkBanda.CheckState = 0 Then chkBanda.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	Private Sub txtfecha_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtfecha.Click
		If chkfecha.CheckState = 0 Then chkfecha.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	Private Sub txtFrecuencia_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFrecuencia.Click
		If chkFrecuencia.CheckState = 0 Then chkFrecuencia.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	Private Sub TxtLocalidad_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtLocalidad.Click
		If chklocalidad.CheckState < 1 Then chklocalidad.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	Private Sub TxtMemoria_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtMemoria.Click
		If chkmemoria.CheckState = 0 Then chkmemoria.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	Sub borrar()
		txtFrecuencia.Text = ""
		chkFrecuencia.CheckState = System.Windows.Forms.CheckState.Unchecked
		TxtMemoria.Text = ""
		chkmemoria.CheckState = System.Windows.Forms.CheckState.Unchecked
		TxtLocalidad.Text = ""
		chklocalidad.CheckState = System.Windows.Forms.CheckState.Unchecked
		TxtBanda.Text = ""
		chkBanda.CheckState = System.Windows.Forms.CheckState.Unchecked
		txtfecha.Text = ""
		chkfecha.CheckState = System.Windows.Forms.CheckState.Unchecked
		chkcomprobado.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	Function Frecuencia() As Object
		Dim khz As Object
		Dim mhz As Object
		Dim punto As Object
		On Error Resume Next
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(1, txtFrecuencia.Text, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = VB.Left(txtFrecuencia.Text, punto - 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		khz = Mid(txtFrecuencia.Text, punto + 1)
		
		Select Case Len(mhz)
			Case 1
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mhz = "00" + mhz
			Case 2
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mhz = "0" + mhz
		End Select
		
		Select Case Len(khz)
			Case 0
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				khz = "0000"
			Case 1
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				khz = khz + "000"
			Case 2
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				khz = khz + "00"
			Case 3
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				khz = khz + "0"
		End Select
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Frecuencia = mhz + "." + khz
	End Function
	
	Private Sub txtobservaciones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtobservaciones.Click
		chkobservaciones.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
End Class