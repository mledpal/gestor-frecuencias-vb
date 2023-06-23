VERSION 5.00
Begin VB.Form frmrepetidores 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Lista de Repetidores Posibles"
   ClientHeight    =   3900
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   4980
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3900
   ScaleWidth      =   4980
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command2 
      Caption         =   "Ver Cercanas"
      Height          =   375
      Left            =   3480
      TabIndex        =   27
      Top             =   600
      Width           =   1455
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Otra Frecuencia"
      Height          =   375
      Left            =   1800
      TabIndex        =   26
      Top             =   600
      Width           =   1455
   End
   Begin VB.TextBox txtrep 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   4
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   21
      Top             =   3000
      Width           =   1575
   End
   Begin VB.TextBox txtrep 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   5
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   20
      Top             =   3480
      Width           =   1575
   End
   Begin VB.CommandButton botver 
      Caption         =   "Ver"
      Enabled         =   0   'False
      Height          =   375
      Index           =   4
      Left            =   4200
      TabIndex        =   19
      Top             =   3000
      Width           =   735
   End
   Begin VB.CommandButton botver 
      Caption         =   "Ver"
      Enabled         =   0   'False
      Height          =   375
      Index           =   5
      Left            =   4200
      TabIndex        =   18
      Top             =   3480
      Width           =   735
   End
   Begin VB.CommandButton botguardar 
      Caption         =   "Guardar"
      Height          =   375
      Left            =   120
      TabIndex        =   17
      Top             =   600
      Visible         =   0   'False
      Width           =   1455
   End
   Begin VB.CommandButton botver 
      Caption         =   "Ver"
      Enabled         =   0   'False
      Height          =   375
      Index           =   1
      Left            =   4200
      TabIndex        =   12
      Top             =   1560
      Width           =   735
   End
   Begin VB.CommandButton botver 
      Caption         =   "Ver"
      Enabled         =   0   'False
      Height          =   375
      Index           =   2
      Left            =   4200
      TabIndex        =   11
      Top             =   2040
      Width           =   735
   End
   Begin VB.CommandButton botver 
      Caption         =   "Ver"
      Enabled         =   0   'False
      Height          =   375
      Index           =   3
      Left            =   4200
      TabIndex        =   10
      Top             =   2520
      Width           =   735
   End
   Begin VB.CommandButton botver 
      Caption         =   "Ver"
      Enabled         =   0   'False
      Height          =   375
      Index           =   0
      Left            =   4200
      TabIndex        =   9
      Top             =   1080
      Width           =   735
   End
   Begin VB.TextBox txtfrecuencia 
      Alignment       =   2  'Center
      BackColor       =   &H00808080&
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H0000FF00&
      Height          =   375
      Left            =   120
      Locked          =   -1  'True
      TabIndex        =   8
      Top             =   120
      Width           =   4815
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
      Top             =   3525
      Visible         =   0   'False
      Width           =   4980
   End
   Begin VB.TextBox txtrep 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   3
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   7
      Top             =   2520
      Width           =   1575
   End
   Begin VB.TextBox txtrep 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   2
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   6
      Top             =   2040
      Width           =   1575
   End
   Begin VB.TextBox txtrep 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   1
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   5
      Top             =   1560
      Width           =   1575
   End
   Begin VB.TextBox txtrep 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   0
      Left            =   1800
      Locked          =   -1  'True
      TabIndex        =   4
      Top             =   1080
      Width           =   1575
   End
   Begin VB.Label Label7 
      Caption         =   "Repetidor + 7.6 Khz"
      Height          =   255
      Left            =   120
      TabIndex        =   25
      Top             =   3000
      Width           =   1455
   End
   Begin VB.Label Label4 
      Caption         =   "Repetidor - 7.6 Khz"
      Height          =   255
      Left            =   120
      TabIndex        =   24
      Top             =   3480
      Width           =   1455
   End
   Begin VB.Label numreg 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   4
      Left            =   3480
      TabIndex        =   23
      Top             =   3000
      Width           =   495
   End
   Begin VB.Label numreg 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   5
      Left            =   3480
      TabIndex        =   22
      Top             =   3480
      Width           =   495
   End
   Begin VB.Label numreg 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   3
      Left            =   3480
      TabIndex        =   16
      Top             =   2520
      Width           =   495
   End
   Begin VB.Label numreg 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   2
      Left            =   3480
      TabIndex        =   15
      Top             =   2040
      Width           =   495
   End
   Begin VB.Label numreg 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   1
      Left            =   3480
      TabIndex        =   14
      Top             =   1560
      Width           =   495
   End
   Begin VB.Label numreg 
      Alignment       =   2  'Center
      Height          =   375
      Index           =   0
      Left            =   3480
      TabIndex        =   13
      Top             =   1080
      Width           =   495
   End
   Begin VB.Label Label3 
      Caption         =   "Repetidor - 600 Khz"
      Height          =   255
      Left            =   120
      TabIndex        =   3
      Top             =   1560
      Width           =   1455
   End
   Begin VB.Label Label2 
      Caption         =   "Repetidor + 4.6 Mhz"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   2040
      Width           =   1455
   End
   Begin VB.Label Label1 
      Caption         =   "Repetidor - 4.6 Mhz"
      Height          =   255
      Left            =   120
      TabIndex        =   1
      Top             =   2520
      Width           =   1455
   End
   Begin VB.Label lbl1 
      Caption         =   "Repetidor + 600 Khz"
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   1080
      Width           =   1455
   End
End
Attribute VB_Name = "frmrepetidores"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim mhz, khz, frecu As Currency
Dim rep(5), otrafrec As String
Dim cadenasbusqueda(5) As String

Sub verrepetidores()
On Error Resume Next

Frecuencia = Modulo.LeerFrec()
Frecuencia = Mid(Frecuencia, 1, 8)
txtFrecuencia.Text = Frecuencia

punto = InStr(Frecuencia, ".")
mhz = Left(Frecuencia, (punto - 1))
khz = Mid(Frecuencia, (punto + 1))

frecu = mhz + (khz / 10000)

rep(0) = CStr(frecu + 0.6)
rep(1) = CStr(frecu - 0.6)
rep(2) = CStr(frecu + 4.6)
rep(3) = CStr(frecu - 4.6)
rep(4) = CStr(frecu + 7.6)
rep(5) = CStr(frecu - 7.6)

For n = 0 To 5
    coma = InStr(rep(n), ",")
    mhzs = Left(rep(n), (coma - 1))
    khzs = Mid(rep(n), (coma + 1))
    
    If Len(mhzs) = 0 Then mhzs = "000"
    If Len(mhzs) = 1 Then mhzs = "00" + mhzs
    If Len(mhzs) = 2 Then mhzs = "0" + mhzs
    If Len(khzs) = 0 Then khzs = "0000"
    If Len(khzs) = 1 Then khzs = khzs + "000"
    If Len(khzs) = 2 Then khzs = khzs + "00"
    If Len(khzs) = 3 Then khzs = khzs + "0"
    
    rep(n) = mhzs + "." + khzs
    txtrep(n) = rep(n)
Next n

For n = 0 To 5
    cadenasbusqueda(n) = "Frecuencia=" + Chr(39) + rep(n) + Chr(39)
    bd.Recordset.FindFirst cadenasbusqueda(n)
    
    If bd.Recordset.NoMatch = False Then
        NumReg(n).Caption = bd.Recordset("Registro")
        txtrep(n).BackColor = vbBlue
        txtrep(n).ForeColor = vbYellow
        botver(n).Enabled = True
    Else
        NumReg(n).Caption = "No"
    End If
    
Next n

End Sub

Private Sub botguardar_Click()
    frecuenciabuscada = Modulo.LeerFrec
    opcion = MsgBox("¿Desea Añadir dicha Frecuencia?", vbYesNo, "Añadir Frecuencia")
    
    If opcion = vbYes Then
        Unload Me
        frmnuevo.Show (modal)
        frmnuevo.txtFrecuencia.Text = frecuenciabuscada
        frmnuevo.TxtObserv.Text = "Nueva Busqueda"
    End If

botguardar.Visible = False

End Sub

Private Sub botver_Click(Index As Integer)
Modulo.grabar (cadenasbusqueda(Index))
frmResultados.Show (modal)
End Sub

Private Sub Command1_Click()
    
    otrafrec = InputBox("Otra frecuencia para comprobar repetidores", "Frecuencia")


    If otrafrec = "" Then
        MsgBox "No Ha introducido ninguna frecuencia", vbInformation
        Exit Sub
    End If

    punto = InStr(1, otrafrec, ".")
    mhz = Left(otrafrec, (punto - 1))
    khz = Mid(otrafrec, (punto + 1))
    
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
    otrafrec = mhz + "." + khz
Else
    
End If
    
    
    Modulo.grabarFrec (otrafrec)
    
    Call frmFrecuencias.SituarBD
    bd.Refresh
    Call verrepetidores
    
End Sub

Private Sub Command2_Click()
    'desplazamiento = InputBox("Introduzca el AB para búsqueda", "Ancho de banda de búsqueda")
    
    ' Busqueda en un AB de 50 khz
    Frecuencia = txtFrecuencia.Text
    punto = InStr(1, Frecuencia, ".")
    mhz = Left(Frecuencia, (punto - 1))
    khz = Mid(Frecuencia, (punto + 1))
        
    limits = khz + 50
    limiti = khz - 50
    
    cadenabusqueda = "Mhz=" + Chr(39) + CStr(mhz) + Chr(39) + " and ( khz>" + Chr(39) + CStr(limiti) + Chr(39) + " and khz<" + Chr(39) + CStr(limits) + Chr(39) + ")"
    
    bd.Recordset.FindFirst cadenabusqueda
    
    If Not bd.Recordset.NoMatch Then
        Modulo.grabar (cadenabusqueda)
        Unload Me
        frmResultados.Show (modal)
    Else
        MsgBox "No hay frecuencias cercanas en un margen de 50 Khz"
    End If
    
End Sub

Sub Form_Activate()
Call frmFrecuencias.SituarBD
bd.Refresh
Call verrepetidores
End Sub

Private Sub Form_GotFocus()
Call frmFrecuencias.SituarBD
bd.Refresh
Call verrepetidores
End Sub

Sub adaptar(mhzs, khzs As String)

Select Case Len(mhzs)
    Case 1
        mhzs = "00" + mhzs
    Case 2
        mhzs = "0" + mhzs
End Select

Select Case Len(khzs)
    Case 0
        khzs = "0000"
    Case 1
        khzs = khzs + "000"
    Case 2
        khzs = khzs + "00"
    Case 3
        khzs = khzs + "0"
End Select
End Sub

