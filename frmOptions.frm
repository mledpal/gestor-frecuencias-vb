VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "COMDLG32.OCX"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form frmOptions 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "Opciones"
   ClientHeight    =   3690
   ClientLeft      =   2565
   ClientTop       =   1500
   ClientWidth     =   3870
   Icon            =   "frmOptions.frx":0000
   KeyPreview      =   -1  'True
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3690
   ScaleWidth      =   3870
   StartUpPosition =   2  'CenterScreen
   Begin VB.CommandButton Command4 
      Caption         =   "Configurar"
      Enabled         =   0   'False
      Height          =   255
      Left            =   2280
      TabIndex        =   23
      Top             =   2040
      Width           =   1095
   End
   Begin VB.Frame Frame1 
      Caption         =   "ACTUALIZACIONES"
      Height          =   2295
      Left            =   1920
      TabIndex        =   19
      Top             =   120
      Width           =   1935
      Begin VB.CommandButton Command3 
         Caption         =   "Desde Internet"
         Height          =   375
         Left            =   120
         TabIndex        =   22
         Top             =   1440
         Width           =   1695
      End
      Begin VB.CommandButton Command2 
         Caption         =   "Desde MDB . . ."
         Enabled         =   0   'False
         Height          =   375
         Left            =   120
         TabIndex        =   21
         Top             =   840
         Width           =   1695
      End
      Begin VB.CommandButton Command1 
         Caption         =   "Desde RGF . . ."
         Enabled         =   0   'False
         Height          =   375
         Left            =   120
         TabIndex        =   20
         Top             =   360
         Width           =   1695
      End
   End
   Begin VB.Frame framdatos 
      Caption         =   "Informacion"
      Height          =   855
      Left            =   120
      TabIndex        =   11
      Top             =   2520
      Width           =   3735
      Begin VB.TextBox txttotal 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         DataField       =   "Registro"
         DataSource      =   "BD"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   2520
         Locked          =   -1  'True
         TabIndex        =   16
         Top             =   480
         Width           =   1095
      End
      Begin VB.TextBox txtexportar 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         DataField       =   "Registro"
         DataSource      =   "BD"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   1320
         Locked          =   -1  'True
         TabIndex        =   14
         Top             =   480
         Width           =   1095
      End
      Begin VB.TextBox txtComprobado 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         DataField       =   "Registro"
         DataSource      =   "BD"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   285
         Left            =   120
         Locked          =   -1  'True
         TabIndex        =   12
         Top             =   480
         Width           =   1095
      End
      Begin VB.Label Label3 
         Alignment       =   2  'Center
         Caption         =   "Total"
         Height          =   255
         Left            =   2520
         TabIndex        =   17
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label2 
         Alignment       =   2  'Center
         Caption         =   "Exportables"
         Height          =   255
         Left            =   1320
         TabIndex        =   15
         Top             =   240
         Width           =   1095
      End
      Begin VB.Label Label4 
         Alignment       =   2  'Center
         Caption         =   "Comprobados"
         Height          =   255
         Left            =   120
         TabIndex        =   13
         Top             =   240
         Width           =   1095
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
      Top             =   3315
      Visible         =   0   'False
      Width           =   3870
   End
   Begin VB.CommandButton botañade 
      Caption         =   "Añadir TXT"
      Height          =   375
      Left            =   120
      TabIndex        =   10
      Top             =   1560
      Width           =   1695
   End
   Begin VB.CommandButton botborrar 
      Appearance      =   0  'Flat
      BackColor       =   &H00C0C0C0&
      Caption         =   "Reset . . ."
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   120
      MaskColor       =   &H000000FF&
      TabIndex        =   9
      Top             =   2040
      Width           =   1695
   End
   Begin VB.CommandButton botload 
      Caption         =   "Cargar TXT"
      Height          =   375
      Left            =   120
      TabIndex        =   8
      Top             =   1080
      Width           =   1695
   End
   Begin VB.CommandButton botgenera 
      Caption         =   "Generar TXT . . ."
      Height          =   375
      Left            =   120
      TabIndex        =   7
      Top             =   600
      Width           =   1695
   End
   Begin VB.CommandButton botorden 
      Caption         =   "Ordenar Nº Registro"
      Height          =   375
      Left            =   120
      TabIndex        =   6
      Top             =   120
      Width           =   1695
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      Height          =   3780
      Index           =   3
      Left            =   -20000
      ScaleHeight     =   3780
      ScaleWidth      =   5685
      TabIndex        =   2
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample4 
         Caption         =   "Ejemplo 4"
         Height          =   1785
         Left            =   2100
         TabIndex        =   5
         Top             =   840
         Width           =   2055
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      Height          =   3780
      Index           =   2
      Left            =   -20000
      ScaleHeight     =   3780
      ScaleWidth      =   5685
      TabIndex        =   1
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample3 
         Caption         =   "Ejemplo 3"
         Height          =   1785
         Left            =   1545
         TabIndex        =   4
         Top             =   675
         Width           =   2055
      End
   End
   Begin VB.PictureBox picOptions 
      BorderStyle     =   0  'None
      Height          =   3780
      Index           =   1
      Left            =   -20000
      ScaleHeight     =   3780
      ScaleWidth      =   5685
      TabIndex        =   0
      TabStop         =   0   'False
      Top             =   480
      Width           =   5685
      Begin VB.Frame fraSample2 
         Caption         =   "Ejemplo 2"
         Height          =   1785
         Left            =   645
         TabIndex        =   3
         Top             =   300
         Width           =   2055
         Begin MSComDlg.CommonDialog dialogo 
            Left            =   0
            Top             =   0
            _ExtentX        =   847
            _ExtentY        =   847
            _Version        =   393216
            DefaultExt      =   "RGF"
            FileName        =   "Frecuencias.RGF"
            Filter          =   " Registro | *.log ; Registro Gestor | *.RGF"
            FilterIndex     =   2
            InitDir         =   "C:\"
         End
      End
   End
   Begin ComctlLib.ProgressBar Progreso 
      Height          =   255
      Left            =   120
      TabIndex        =   18
      Top             =   3360
      Width           =   3735
      _ExtentX        =   6588
      _ExtentY        =   450
      _Version        =   327682
      Appearance      =   1
   End
End
Attribute VB_Name = "frmOptions"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim seguir As Boolean
Dim TXT As Registro
Dim fin As Boolean
Dim reg As Integer
Dim cont As Integer
Dim regprogram As Integer

Private Sub botsalir_Click()
If chktsr.Value = True Then
    frmOptions.Visible = False
    Load frmOptions
Else
    Unload Me
    Load frmFrecuencias
End If

End Sub

Private Sub botvolver_Click()
Unload Me
Load frmFrecuencias
End Sub

Private Sub Timer1_Timer()
If chktsr.Value = True Then
    botsalir.Visible = True
Else
    botsalir.Visible = False
End If

End Sub
Private Sub botañade_Click()
frmimportar.Show
Unload Me
End Sub

Private Sub botborrar_Click()
    MsgBox "Esta acción borrará todos los datos de la BD", vbInformation
    frmborrarbd.Visible = True
    Unload Me
End Sub

Sub botorden_Click()
        
    Call numreg
    
    Dim mhz, khz As String
    
    cont = 0
    reg = 1
    Do
        Progreso.Value = cont
        
        bd.Recordset.Edit
        bd.Recordset("Registro") = reg
        
        Frecuen = bd.Recordset("Frecuencia")
        mhz = Left(Frecuen, 3)
        khz = Right(Frecuen, 4)
        bd.Recordset("Mhz") = mhz
        bd.Recordset("Khz") = khz
        bd.Recordset.Update
        
        reg = reg + 1
        cont = cont + 1
        
        bd.Recordset.MoveNext
    Loop While bd.Recordset.EOF = False

    ' MsgBox "Registros Actualizados con éxito", vbInformation
    Progreso.Value = Progreso.Min
    bd.Refresh
    Unload Me
    frmFrecuencias.Show
    
End Sub
Private Sub botload_Click()
    
    Dim Mensaje, Estilo, Título, Ayuda, Ctxt, Respuesta, MiCadena
    Mensaje = "Esta acción reemplazará todos sus datos actuales ¿Desea continuar?"
    Estilo = vbYesNo + vbInformation + vbDefaultButton2
    Título = "Recargar Base De Datos"
    Respuesta = MsgBox(Mensaje, Estilo, Título, Ayuda, Ctxt)
    
    If Respuesta = vbYes Then
        
        dialogo.ShowOpen
                
        If dialogo.FileName = "" Then Exit Sub
        
        Open dialogo.FileName For Binary As #1
        Get #1, , regprogram
        Close #1

        If regprogram = 7980 Then
            
            MsgBox "Clave de archivo de Seguridad Valida. Se procede a la carga . . ."
            Call frmborrarbd.borrar
            Close #1
            Call frmimportar.descargar(0)
            Exit Sub
        Else
            MsgBox "Archivo no válido o clave de seguridad incorrecta"
        End If
    
    End If
frmFrecuencias.Show
Unload Me
End Sub
Sub botgenera_Click()
frmexportar.Show
Unload Me
End Sub

Sub numreg()
On Error Resume Next
bd.Refresh
bd.Recordset.MoveFirst
Do
    cont = cont + 1
    bd.Recordset.MoveNext
Loop While bd.Recordset.EOF = False
bd.Recordset.MoveFirst

Progreso.Min = 0
Progreso.Max = cont
bd.Recordset.MoveFirst

End Sub

Private Sub Command3_Click()
    frmactualizar.Show modal
    Unload Me
End Sub

Private Sub Form_Activate()
On Error Resume Next
bd.Refresh
bd.Recordset.MoveFirst

Do
    If bd.Recordset("Exportar") = True Then e = e + 1
    If bd.Recordset("Comprobado") = True Then C = C + 1
    bd.Recordset.MoveNext
Loop While Not bd.Recordset.EOF
bd.Refresh
bd.Recordset.MoveLast
txttotal.Text = bd.Recordset.RecordCount
txtexportar.Text = e
txtComprobado.Text = C
End Sub
