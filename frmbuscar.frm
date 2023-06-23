VERSION 5.00
Begin VB.Form frmbuscar 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Busqueda"
   ClientHeight    =   4320
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4245
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4320
   ScaleWidth      =   4245
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox txtmodo 
      Height          =   315
      ItemData        =   "frmbuscar.frx":0000
      Left            =   2160
      List            =   "frmbuscar.frx":001C
      Sorted          =   -1  'True
      TabIndex        =   16
      Top             =   3240
      Width           =   1815
   End
   Begin VB.TextBox txtobservaciones 
      Alignment       =   2  'Center
      DataField       =   "Observaciones"
      Height          =   405
      Left            =   2160
      TabIndex        =   15
      Top             =   2280
      Width           =   1815
   End
   Begin VB.CheckBox chklocalidad 
      Caption         =   "Localidad"
      Height          =   255
      Left            =   240
      TabIndex        =   8
      Top             =   1320
      Width           =   1455
   End
   Begin VB.CheckBox chkmemoria 
      Caption         =   "Memoria"
      Height          =   255
      Left            =   240
      TabIndex        =   7
      Top             =   840
      Width           =   1455
   End
   Begin VB.Data BD 
      Align           =   2  'Align Bottom
      Caption         =   "Frecuencias"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   -1  'True
      Height          =   375
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Frecuencias"
      Top             =   3945
      Visible         =   0   'False
      Width           =   4245
   End
   Begin VB.TextBox txtfecha 
      Alignment       =   2  'Center
      DataField       =   "Localidad"
      Height          =   405
      Left            =   2160
      TabIndex        =   4
      Top             =   1800
      Width           =   1815
   End
   Begin VB.CommandButton botbusca 
      Caption         =   "Ejecutar Busqueda"
      Default         =   -1  'True
      Height          =   495
      Left            =   2160
      TabIndex        =   11
      Top             =   3720
      Width           =   1935
   End
   Begin VB.TextBox txtFrecuencia 
      Alignment       =   2  'Center
      DataField       =   "Frecuencia"
      Height          =   405
      Left            =   2160
      MaxLength       =   8
      TabIndex        =   1
      Top             =   360
      Width           =   1815
   End
   Begin VB.TextBox TxtLocalidad 
      Alignment       =   2  'Center
      DataField       =   "Localidad"
      Height          =   405
      Left            =   2160
      TabIndex        =   3
      Top             =   1320
      Width           =   1815
   End
   Begin VB.TextBox TxtMemoria 
      Alignment       =   2  'Center
      DataField       =   "Memoria"
      Height          =   375
      Left            =   2160
      MaxLength       =   2
      TabIndex        =   2
      Top             =   840
      Width           =   1815
   End
   Begin VB.ComboBox TxtBanda 
      DataField       =   "Banda"
      Height          =   315
      IntegralHeight  =   0   'False
      ItemData        =   "frmbuscar.frx":0048
      Left            =   2160
      List            =   "frmbuscar.frx":0067
      Sorted          =   -1  'True
      TabIndex        =   5
      Top             =   2760
      Width           =   1815
   End
   Begin VB.Frame Opciones 
      Caption         =   "Buscar por . . ."
      Height          =   4215
      Left            =   120
      TabIndex        =   0
      Top             =   0
      Width           =   1935
      Begin VB.CheckBox chkmodo 
         Caption         =   "Modo"
         Height          =   255
         Left            =   120
         TabIndex        =   17
         Top             =   3360
         Width           =   1455
      End
      Begin VB.CheckBox chkobservaciones 
         Caption         =   "Observaciones"
         Height          =   375
         Left            =   120
         TabIndex        =   14
         Top             =   2280
         Width           =   1455
      End
      Begin VB.CheckBox chkcomprobado 
         Caption         =   "Comprobado"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   3840
         Width           =   1455
      End
      Begin VB.CheckBox chkBanda 
         Caption         =   "Banda"
         Height          =   255
         Left            =   120
         TabIndex        =   10
         Top             =   2880
         Width           =   1455
      End
      Begin VB.CheckBox chkfecha 
         Caption         =   "Fecha"
         Height          =   255
         Left            =   120
         TabIndex        =   9
         Top             =   1800
         Width           =   1455
      End
      Begin VB.CheckBox chkFrecuencia 
         Caption         =   "Frecuencia"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   360
         Width           =   1455
      End
   End
   Begin VB.Label Label 
      AutoSize        =   -1  'True
      Height          =   195
      Left            =   120
      TabIndex        =   12
      Top             =   2880
      Width           =   45
   End
End
Attribute VB_Name = "frmbuscar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim frecu As Currency
Dim cadenabusqueda As String
Dim cadena As String



Private Sub botbusca_Click()
cadenabusqueda = ""
BD.Refresh

' Frecuencia
If chkFrecuencia.Value = 1 Or chkFrecuencia.Value = 2 Then
    
    If Right(txtFrecuencia.Text, 1) = "M" Or Right(txtFrecuencia.Text, 1) = "m" Or Right(txtFrecuencia.Text, 1) = "K" Or Right(txtFrecuencia.Text, 1) = "k" Then GoTo Frecuencia2
    Frec = Frecuencia
    punto = InStr(Frec, ".")
    mhz = Left(Frec, (punto - 1))
    khz = Mid(Frec, (punto + 1))
    
    If IsNumeric(mhz) = True And IsNumeric(khz) = True Then
        If Len(Frec) > 0 Then
            cadenafrecuencia = "Frecuencia=" + Chr(39) + Frec + Chr(39)
        Else
            Call FALLO
        End If
    Else
        Call FALLO
    End If
End If


' Frecuencia, Busqueda por MHZ o por KHZ

Frecuencia2:
If chkFrecuencia.Value = 1 Or chkFrecuencia.Value = 2 Then
    
    Frec = Frecuencia
    Dato = UCase(Right(txtFrecuencia.Text, 1))
    
    Select Case Dato
        
        Case "M"
            Frec = Mid(txtFrecuencia.Text, 1, (Len(txtFrecuencia.Text) - 1))
            If Len(Frec) <= 0 Then Call FALLO
            cadenafrecuencia = "Mhz=" + Chr(39) + Frec + Chr(39)
        
        Case "K"
            Frec = Mid(txtFrecuencia.Text, 1, (Len(txtFrecuencia.Text) - 1))
            If Len(Frec) <= 0 Then Call FALLO
            
            cadenafrecuencia = "Khz=" + Chr(39) + Frec + Chr(39)
    End Select

End If

' Memoria
If chkmemoria.Value = 1 Then
    If TxtMemoria.Text = "" Then
        MsgBox "No ha Introducido ningún valor", vbCritical
        Call borrar
        cadenabusqueda = "FALLO"
        Exit Sub
    Else
        mem = TxtMemoria.Text
        If IsNumeric(TxtMemoria.Text) = True Then
           
            If Len(mem) > 0 Then
                If CInt(mem) >= 0 And CInt(mem) <= 50 Then
                    cadenamemoria = "Memoria=" + mem
                Else
                    MsgBox "El Escaner Solo tiene 50 Memorias o la Auxiliar 0", vbInformation
                    cadenabusqueda = "FALLO"
                    Exit Sub
                End If
            Else
                Call FALLO
            End If
        End If
    End If
End If

If chkmemoria.Value = 2 Then ' Busca todas las Memorias Almacenadas
    ban = Chr(39) + Chr(39)
    cadenabusqueda = "Memoria > 0 and Memoria < 51"
End If

' Modo de recepcion
If chkmodo.Value = 2 Or chkmodo.Value = 1 Then
    modo = Chr(39) + txtmodo.Text + Chr(39)
    Select Case chkmodo.Value
        Case 1
            cadenamodo = "Modo=" + modo
        Case 2
            cadenamodo = "Modo<>" + modo
    End Select
End If


'Localidad
If chklocalidad.Value = 1 Or chklocalidad.Value = 2 Then
    loca = TxtLocalidad.Text
    If Len(loca) > 0 Then
        Select Case chklocalidad.Value
            Case 1
                cadenalocalidad = "Localidad=" + Chr(39) + loca + Chr(39)
            Case 2
                cadenalocalidad = "Localidad<>" + Chr(39) + loca + Chr(39)
        End Select
    Else
        Call FALLO
    End If
End If

' Fecha
Valor = chkfecha.Value

If Valor = 1 Or Valor = 2 Then
    If IsDate(txtfecha.Text) = True Then
        fech = CStr(CSng(CDate(txtfecha.Text)))
        If Len(fech) > 0 Then
            Select Case Valor
                Case 1
                    cadenafecha = "Fecha=" + fech
                Case 2
                    cadenafecha = "Fecha<>" + fech
            End Select
        Else
            MsgBox "Teclee una Fecha Válida", vbExclamation
            Exit Sub
        End If
    Else
        MsgBox "Fecha No Válida", vbInformation
        Call FALLO
    End If
End If

' Observaciones
If chkobservaciones.Value = 1 Or chkobservaciones.Value = 2 Then
    Select Case chkobservaciones.Value
        Case 1
            cadenaobservaciones = "Observaciones=" + Chr(39) + txtobservaciones.Text + Chr(39)
        Case 2
            cadenaobservaciones = "Observaciones<>" + Chr(39) + txtobservaciones.Text + Chr(39)
    End Select
End If

' Banda
If chkBanda.Value = 1 Or chkBanda.Value = 2 Then
    ban = Chr(39) + TxtBanda.Text + Chr(39)
    If Len(ban) > 0 Then
        Select Case chkBanda.Value
            Case 1
                cadenabanda = "Banda=" + ban
            Case 2
                cadenabanda = "Banda<>" + ban
        End Select
    Else
        Call FALLO
    End If
End If

'Comprobado
If chkcomprobado.Value = 1 Then cadenacomprobado = "Comprobado=True"
If chkcomprobado.Value = 2 Then cadenacomprobado = "Comprobado=False"
If cadenabusqueda <> "FALLO" Then

    If chkFrecuencia.Value = 1 Then cadenabusqueda = cadenabusqueda + " and " + cadenafrecuencia
    If chkmemoria.Value = 1 Then cadenabusqueda = cadenabusqueda + " and " + cadenamemoria
    If chklocalidad.Value = 1 Or chklocalidad.Value = 2 Then cadenabusqueda = cadenabusqueda + " and " + cadenalocalidad
    If chkfecha.Value = 1 Or chkfecha.Value = 2 Then cadenabusqueda = cadenabusqueda + " and " + cadenafecha
    If chkBanda.Value = 1 Or chkBanda.Value = 2 Then cadenabusqueda = cadenabusqueda + " and " + cadenabanda
    If chkcomprobado.Value = 1 Or chkcomprobado.Value = 2 Then cadenabusqueda = cadenabusqueda + " and " + cadenacomprobado
    If chkobservaciones.Value = 1 Or chkobservaciones.Value = 2 Then cadenabusqueda = cadenabusqueda + " and " + cadenaobservaciones
    If chkmodo.Value = 1 Or chkmodo.Value = 2 Then cadenabusqueda = cadenabusqueda + " and " + cadenamodo
Else
    Me.Show (modal)
End If

cadenabusqueda = Trim(cadenabusqueda)

If Left(cadenabusqueda, 3) = "and" Then
    cadenabusqueda = Mid(cadenabusqueda, 4)
    cadenabusqueda = Trim(cadenabusqueda)
End If
longit = Len(cadenabusqueda)

If cadenabusqueda = "FALLO" Or longit = 0 Then Exit Sub
If longit > 0 Or cadenabusqueda <> "FALLO" Then


    BD.Recordset.FindFirst cadenabusqueda

        If Not BD.Recordset.NoMatch Then
            Modulo.grabar (cadenabusqueda)
            Unload Me
            frmResultados.Show (modal)
        Else
            MsgBox "No existen coincidencias para la cadena : " + Chr(10) + Chr(13) + cadenabusqueda, vbInformation
            Call borrar
            cadena = Left(cadenabusqueda, 4)

            If cadena = "Frec" Then
                
                ' Rutina para Averiguar los Posibles Repetidores
                ' o frecuencias de desplazamiento
                frecuenciabuscada = Left(Right(cadenabusqueda, 9), 8)
                Modulo.grabarFrec (frecuenciabuscada)
               
                frmrepetidores.Show (modal)
                frmrepetidores.botguardar.Visible = True
            End If
        End If
    
    Else
        MsgBox "No hay una cadena de busqueda válida", vbCritical
    End If

End Sub

Sub FALLO()
    MsgBox "Introduzca un valor de búsqueda válido", vbCritical
    cadenabusqueda = "FALLO"
    Call borrar
End Sub

Private Sub chkcomprobado_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chkcomprobado.Value = 2 Then
        chkcomprobado.Value = 0
    Else
        chkcomprobado.Value = 2
    End If
End If

End Sub
Private Sub chkLocalidad_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chklocalidad.Value = 2 Then
        chklocalidad.Value = 0
    Else
        chklocalidad.Value = 2
    End If
End If

End Sub
Private Sub chkbanda_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chkBanda.Value = 2 Then
        chkBanda.Value = 0
    Else
        chkBanda.Value = 2
    End If
End If

End Sub


Private Sub chkfecha_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chkfecha.Value = 2 Then
        chkfecha.Value = 0
    Else
        chkfecha.Value = 2
    End If
End If

End Sub
Private Sub chkmodo_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chkmodo.Value = 2 Then
        chkmodo.Value = 0
    Else
        chkmodo.Value = 2
    End If
End If

End Sub
Private Sub chkmemoria_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chkmemoria.Value = 2 Then
        chkmemoria.Value = 0
        TxtMemoria.Enabled = True
        TxtMemoria.BackColor = vbWhite
        TxtMemoria.MaxLength = 2
        TxtMemoria.Text = ""
    Else
        chkmemoria.Value = 2
        TxtMemoria.Enabled = False
        TxtMemoria.BackColor = &H8000000F
        TxtMemoria.MaxLength = 5
        TxtMemoria.Text = "Todas"
    End If
End If

If Button = 1 Then
    TxtMemoria.Enabled = True
    TxtMemoria.BackColor = vbWhite
End If

End Sub

Private Sub chkmodo_Click()
    If Button = 2 Then
        If chkmodo.Value = 2 Then
            chkmodo.Value = 0
        Else
            chkmodo.Value = 2
        End If
    End If
End Sub

Private Sub chkobservaciones_MouseUp(Button As Integer, Shift As Integer, x As Single, y As Single)

If Button = 2 Then
    If chkobservaciones.Value = 2 Then
        chkobservaciones.Value = 0
    Else
        chkobservaciones.Value = 2
    End If
End If

End Sub

Private Sub TxtBanda_Click()
If chkBanda.Value = 0 Then chkBanda.Value = 1
End Sub

Private Sub txtfecha_Click()
If chkfecha.Value = 0 Then chkfecha.Value = 1
End Sub

Private Sub txtFrecuencia_Click()
If chkFrecuencia.Value = 0 Then chkFrecuencia.Value = 1
End Sub

Private Sub TxtLocalidad_click()
If chklocalidad.Value < 1 Then chklocalidad.Value = 1
End Sub

Private Sub TxtMemoria_click()
If chkmemoria.Value = 0 Then chkmemoria.Value = 1
End Sub


Private Sub txtmodo_click()
    If chkmodo.Value = 0 Then chkmodo.Value = 1
End Sub

Sub borrar()
txtFrecuencia.Text = ""
chkFrecuencia.Value = 0
TxtMemoria.Text = ""
chkmemoria.Value = 0
TxtLocalidad.Text = ""
chklocalidad.Value = 0
TxtBanda.Text = ""
chkBanda.Value = 0
txtfecha.Text = ""
chkfecha.Value = 0
chkcomprobado.Value = 0
End Sub

Function Frecuencia()
On Error Resume Next
    punto = InStr(1, txtFrecuencia.Text, ".")
    mhz = Left(txtFrecuencia.Text, (punto - 1))
    khz = Mid(txtFrecuencia.Text, (punto + 1))
    
    Select Case Len(mhz)
        Case 1
            mhz = "00" + mhz
        Case 2
            mhz = "0" + mhz
    End Select
    
    Select Case Len(khz)
        Case 0
            khz = "0000"
        Case 1
            khz = khz + "000"
        Case 2
            khz = khz + "00"
        Case 3
            khz = khz + "0"
    End Select

Frecuencia = mhz + "." + khz
End Function


Private Sub txtobservaciones_Click()
chkobservaciones.Value = 1
End Sub
