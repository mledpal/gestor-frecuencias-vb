VERSION 5.00
Begin VB.Form frminicio 
   BorderStyle     =   0  'None
   Caption         =   "Gestor de Frecuencias"
   ClientHeight    =   4515
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6060
   LinkTopic       =   "Form1"
   ScaleHeight     =   4515
   ScaleWidth      =   6060
   ShowInTaskbar   =   0   'False
   StartUpPosition =   2  'CenterScreen
   Begin VB.PictureBox image 
      AutoRedraw      =   -1  'True
      AutoSize        =   -1  'True
      Height          =   4560
      Left            =   0
      Picture         =   "frminicio.frx":0000
      ScaleHeight     =   4500
      ScaleWidth      =   6000
      TabIndex        =   0
      Top             =   0
      Width           =   6060
      Begin VB.Timer Timer 
         Interval        =   1000
         Left            =   240
         Top             =   480
      End
      Begin VB.Label lblversion 
         BackColor       =   &H00FF0000&
         ForeColor       =   &H0000FFFF&
         Height          =   195
         Left            =   0
         TabIndex        =   1
         Top             =   0
         Width           =   1035
      End
   End
End
Attribute VB_Name = "frminicio"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Load()
    
    If App.PrevInstance = True Then
        Timer.Enabled = False
        MsgBox "Ya existe una copia del programa abierta", vbOKOnly
        End
    End If
    
    lblversion.Caption = "Versión " & App.Major & "." & App.Minor & "." & App.Revision
    lineacomando = Command()
    
    If UCase(Left(Right(lineacomando, 4), 3)) = "RGF" Then
        MsgBox lineacomando
    End If

End Sub


Private Sub Timer_Timer()
    frmFrecuencias.Visible = True
    For delay = 1 To 2000
    Next delay
    Load frmAbout
    Load frmborrarbd
    Load frmbuscar
    Load frmFrecuencias
    Load frmnuevo
    Load frmOptions
    Load frmResultados
    Load frmrepetidores
    Unload Me
    Call frmFrecuencias.SituarBD
End Sub
