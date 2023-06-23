VERSION 5.00
Begin VB.Form frmnuevo 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Nuevo Registro"
   ClientHeight    =   4620
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4860
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   4620
   ScaleWidth      =   4860
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame registro 
      Caption         =   "Registro"
      Height          =   3855
      Index           =   0
      Left            =   120
      TabIndex        =   1
      Top             =   0
      Width           =   4695
      Begin VB.ComboBox txtmodo 
         Height          =   315
         ItemData        =   "frmnuevo.frx":0000
         Left            =   1440
         List            =   "frmnuevo.frx":001F
         Sorted          =   -1  'True
         TabIndex        =   23
         Top             =   3360
         Width           =   855
      End
      Begin VB.TextBox txtregistro 
         Alignment       =   2  'Center
         BackColor       =   &H00808080&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H0000FFFF&
         Height          =   375
         Left            =   3960
         Locked          =   -1  'True
         TabIndex        =   21
         Top             =   120
         Width           =   615
      End
      Begin VB.TextBox txtFrecuencia 
         DataField       =   "Frecuencia"
         Height          =   375
         Left            =   1440
         TabIndex        =   11
         Top             =   720
         Width           =   1335
      End
      Begin VB.TextBox TxtLocalidad 
         DataField       =   "Localidad"
         Height          =   375
         Left            =   1440
         TabIndex        =   10
         Top             =   2400
         Width           =   1215
      End
      Begin VB.TextBox TxtObserv 
         DataField       =   "Observaciones"
         Height          =   615
         Left            =   1440
         MaxLength       =   100
         MultiLine       =   -1  'True
         TabIndex        =   9
         Top             =   1680
         Width           =   3135
      End
      Begin VB.TextBox TxtMemoria 
         DataField       =   "Memoria"
         Height          =   375
         Left            =   1440
         MaxLength       =   2
         TabIndex        =   8
         Text            =   "0"
         Top             =   1200
         Width           =   1335
      End
      Begin VB.ComboBox TxtBanda 
         DataField       =   "Banda"
         Height          =   315
         ItemData        =   "frmnuevo.frx":004F
         Left            =   1440
         List            =   "frmnuevo.frx":006E
         Sorted          =   -1  'True
         TabIndex        =   7
         Top             =   2880
         Width           =   1215
      End
      Begin VB.CheckBox chkcomprobado 
         Caption         =   "Comprobada"
         DataField       =   "Comprobado"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   6
         Top             =   120
         Width           =   1215
      End
      Begin VB.TextBox txtr 
         Alignment       =   2  'Center
         DataField       =   "r"
         Height          =   285
         Left            =   3840
         TabIndex        =   5
         Top             =   1200
         Width           =   735
      End
      Begin VB.TextBox txts 
         Alignment       =   2  'Center
         DataField       =   "s"
         Height          =   285
         Left            =   3840
         TabIndex        =   4
         Top             =   720
         Width           =   735
      End
      Begin VB.ComboBox txtctcss 
         DataField       =   "CTCSS"
         Height          =   315
         ItemData        =   "frmnuevo.frx":00A6
         Left            =   3840
         List            =   "frmnuevo.frx":0146
         TabIndex        =   3
         Text            =   "-----"
         Top             =   2400
         Width           =   735
      End
      Begin VB.ComboBox txtdcs 
         DataField       =   "dcs"
         Height          =   315
         ItemData        =   "frmnuevo.frx":02AA
         Left            =   3840
         List            =   "frmnuevo.frx":03EC
         TabIndex        =   2
         Text            =   "-----"
         Top             =   2880
         Width           =   735
      End
      Begin VB.Label Label12 
         Caption         =   "Modo"
         Height          =   255
         Left            =   720
         TabIndex        =   22
         Top             =   3360
         Width           =   615
      End
      Begin VB.Label Lbl1 
         Caption         =   "Frecuencia  :"
         Height          =   255
         Left            =   360
         TabIndex        =   20
         Top             =   720
         Width           =   975
      End
      Begin VB.Label Lbl2 
         Caption         =   "Memoria :"
         Height          =   255
         Left            =   600
         TabIndex        =   19
         Top             =   1200
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Observaciones :"
         Height          =   255
         Left            =   120
         TabIndex        =   18
         Top             =   1680
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "Localidad :"
         Height          =   255
         Left            =   600
         TabIndex        =   17
         Top             =   2400
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Banda :"
         Height          =   255
         Left            =   840
         TabIndex        =   16
         Top             =   2880
         Width           =   615
      End
      Begin VB.Label Label9 
         Caption         =   "Radio:"
         Height          =   255
         Left            =   3120
         TabIndex        =   15
         Top             =   1200
         Width           =   495
      End
      Begin VB.Label Label8 
         Caption         =   "Señal: "
         Height          =   255
         Left            =   3120
         TabIndex        =   14
         Top             =   720
         Width           =   495
      End
      Begin VB.Label Label10 
         Caption         =   "CTCSS"
         Height          =   255
         Left            =   3120
         TabIndex        =   13
         Top             =   2400
         Width           =   615
      End
      Begin VB.Label Label11 
         Caption         =   "DCS"
         Height          =   255
         Left            =   3120
         TabIndex        =   12
         Top             =   2880
         Width           =   495
      End
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
      Top             =   4245
      Visible         =   0   'False
      Width           =   4860
   End
   Begin VB.CommandButton botnuevo 
      Caption         =   "Aceptar Datos"
      Default         =   -1  'True
      Height          =   495
      Left            =   120
      TabIndex        =   0
      Top             =   3960
      Width           =   4695
   End
End
Attribute VB_Name = "frmnuevo"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim estado, guardada As Boolean
Private Sub botnuevo_Click()
guardada = False
Call frmFrecuencias.SituarBD
bd.Refresh

Dim Mensaje, Estilo, Título, Ayuda, Ctxt, Respuesta, MiCadena
Mensaje = "¿Desea continuar?"
Estilo = vbYesNo + vbInformation + vbDefaultButton1
Título = "Añadir Registro"
Respuesta = MsgBox(Mensaje, Estilo, Título, Ayuda, Ctxt)

If Respuesta = vbYes Then
    If Not bd.Recordset.BOF = True Then
        bd.Recordset.MoveLast
        numreg = bd.Recordset("Registro")
    Else
        numreg = 1
    End If
       
    
' Añadir Registro
    
    punto = InStr(1, txtFrecuencia.Text, ".")
    mhz = Left(txtFrecuencia.Text, (punto - 1))
    khz = Mid(txtFrecuencia.Text, (punto + 1))
    
    If txtFrecuencia.Text = "" Or IsNumeric(mhz) = False Or IsNumeric(khz) = False Then
        MsgBox "Frecuencia Incorrecta", vbCritical, "ERROR GRAVE"
        Unload Me
        Exit Sub
    End If

MEMORIA:
    If IsNumeric(TxtMemoria.Text) = False Then
        MsgBox "La Memoria Introducida no es correcta :" + TxtMemoria.Text, vbInformation
        resp = MsgBox("¿Desea Introducir una memoria correcta?", vbYesNo)
        If resp = vbYes Then
            TxtMemoria.Text = InputBox("Introduzca Memoria : ", "Nueva Memoria")
            GoTo MEMORIA
        Else
            TxtMemoria.Text = "0"
        End If
    End If
    
    Call frmnuevo.txtFrecuencia_Change
        
    If TxtLocalidad.Text = "" Then TxtLocalidad.Text = "N/A"
    If TxtObserv.Text = "" Then TxtObserv.Text = "N/A"
    If IsNumeric(txtr.Text) = False Then txtr.Text = 0
    If IsNumeric(txts.Text) = False Then txts.Text = 0
    
    Call guardar
    If guardada = True Then
        MsgBox "Frecuencia Añadida con Éxito", vbInformation
    Else
        MsgBox "Operacion Cancelada", vbExclamation
    End If
Else
    actualizar = False
End If
frmnuevo.Visible = False
Unload frmnuevo
End Sub

Private Sub Form_Activate()
On Error Resume Next
bd.Refresh
bd.Recordset.MoveLast
ultimoregistro = bd.Recordset("Registro")
txtregistro.Text = CStr(ultimoregistro + 1)
estado = False
End Sub




Sub txtFrecuencia_Change()
On Error Resume Next

If estado = False Then
    bd.Refresh
    bd.Recordset.MoveLast
    numreg = bd.Recordset("Registro") + 1
    fraregistro.Caption = "Registro " + CStr(numreg)
    estado = True
End If

datos = txtFrecuencia.Text
punto = InStr(datos, ".")
mhz = CInt(Trim(Mid(datos, 1, punto)))

TxtBanda.Text = SelecBanda

End Sub
Function Frecuencia()
punto = InStr(1, txtFrecuencia.Text, ".")
mhz = Left(txtFrecuencia.Text, (punto - 1))
khz = Mid(txtFrecuencia.Text, (punto + 1))
    
If IsNumeric(mhz) = True And IsNumeric(khz) = True Then
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
Else
    
End If
End Function

Sub guardar()
On Error Resume Next
Call frmFrecuencias.SituarBD
bd.Refresh
bd.Recordset.MoveLast
numreg = bd.Recordset("Registro")

'Busca la frecuencia y la memoria en la base de datos
'y si ya existe genera un mensaje de error

buscafrec = "Frecuencia=" + Chr(39) + Frecuencia + Chr(39)
buscamem = "Memoria=" + TxtMemoria.Text

bd.Recordset.FindFirst buscafrec
If bd.Recordset.NoMatch = False Then
    Call MsgError(1)
    Exit Sub
    Unload Me
End If

bd.Recordset.FindFirst buscamem
If bd.Recordset.NoMatch = False And TxtMemoria.Text <> "0" Then
    Call MsgError(2)
    Unload Me
    Exit Sub
End If

bd.Recordset.AddNew
    bd.Recordset("Frecuencia") = Frecuencia
    bd.Recordset("Memoria") = CByte(TxtMemoria.Text)
    bd.Recordset("Localidad") = TxtLocalidad.Text
    bd.Recordset("Observaciones") = TxtObserv.Text
    bd.Recordset("Banda") = SelecBanda
    bd.Recordset("Fecha") = Date
    bd.Recordset("Registro") = numreg + 1
    bd.Recordset("Comprobado") = chkcomprobado.Value
    bd.Recordset("R") = txtr.Text
    bd.Recordset("S") = txts.Text
    bd.Recordset("CTCSS") = txtctcss.Text
    bd.Recordset("DCS") = txtdcs.Text
    bd.Recordset("Exportar") = True
    bd.Recordset("Mhz") = mhz
    bd.Recordset("khz") = khz
    bd.Recordset("modo") = txtmodo.Text
bd.Recordset.Update

guardada = True
End Sub

Sub MsgError(ErrNum As Integer)
reg = bd.Recordset("Registro")
Select Case ErrNum
    Case 1
        MsgBox "La Frecuencia ya existe en el registro " + CStr(reg)
    Case 2
        MsgBox "La Memoria esta ocupada por la frecuencia del registro " + CStr(reg)
End Select
guardada = False
Exit Sub
Unload Me
End Sub

Function SelecBanda()
datos = txtFrecuencia.Text
punto = InStr(datos, ".")
mhz = CInt(Trim(Mid(datos, 1, punto)))

Select Case mhz
    Case 120 To 200
        SelecBanda = "2 m"
    
    Case 300 To 500
        SelecBanda = "70 cm"
      
    Case Is > 800
        SelecBanda = "900 Mhz"
        
    Case 20 To 40
        SelecBanda = "27 Mhz"
        
    Case Else
        SelecBanda = "2 m"
End Select
End Function

