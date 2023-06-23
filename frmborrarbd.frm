VERSION 5.00
Begin VB.Form frmborrarbd 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Borrar Base Datos"
   ClientHeight    =   2355
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3795
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   2355
   ScaleWidth      =   3795
   StartUpPosition =   2  'CenterScreen
   Begin VB.Data bd 
      Align           =   2  'Align Bottom
      Caption         =   "BD"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   375
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Frecuencias"
      Top             =   1980
      Width           =   3795
   End
   Begin VB.TextBox txtllave3 
      Alignment       =   2  'Center
      Height          =   285
      IMEMode         =   3  'DISABLE
      Left            =   2040
      PasswordChar    =   "*"
      TabIndex        =   7
      Top             =   1560
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton botgenera 
      Caption         =   "Generar Llave"
      Height          =   375
      Left            =   120
      TabIndex        =   5
      Top             =   120
      Width           =   1455
   End
   Begin VB.CommandButton botcancela 
      Cancel          =   -1  'True
      Caption         =   "Salir"
      Default         =   -1  'True
      Height          =   375
      Left            =   2760
      TabIndex        =   4
      Top             =   120
      Width           =   975
   End
   Begin VB.CommandButton botseguir 
      Caption         =   "¿Seguir?"
      Enabled         =   0   'False
      Height          =   375
      Left            =   1680
      TabIndex        =   3
      Top             =   120
      Visible         =   0   'False
      Width           =   975
   End
   Begin VB.TextBox txtllave2 
      Alignment       =   2  'Center
      Enabled         =   0   'False
      Height          =   285
      Left            =   2040
      MaxLength       =   6
      TabIndex        =   2
      Top             =   1080
      Width           =   1215
   End
   Begin VB.Label lbl 
      Caption         =   "Llave Seguridad"
      Height          =   255
      Left            =   240
      TabIndex        =   8
      Top             =   1560
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Label txtllave 
      Alignment       =   2  'Center
      Height          =   255
      Left            =   2040
      TabIndex        =   6
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label2 
      Caption         =   "Introduzca Llave:"
      Height          =   255
      Left            =   240
      TabIndex        =   1
      Top             =   1080
      Width           =   1335
   End
   Begin VB.Label Label1 
      Caption         =   "Clave Generada:"
      Height          =   255
      Left            =   360
      TabIndex        =   0
      Top             =   720
      Width           =   1335
   End
End
Attribute VB_Name = "frmborrarbd"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim TXT As Registro
Dim llave As Long
Dim llave2 As Long

Private Sub botcancela_Click()
Unload Me
frmborrarbd.Visible = False
End Sub

Private Sub botgenera_Click()

'bd.Refresh
Randomize
llave = Int(Rnd * 999999) + 1
txtllave.Caption = CStr(llave)
txtllave2.Enabled = True
botseguir.Visible = True
botgenera.Enabled = False

End Sub

Private Sub botseguir_Click()
    llave2 = CLng(txtllave2.Text)
    If CStr(llave) = CStr(llave2) Then
        Call borrar
        Unload Me
    Else
        MsgBox "La Llave no es la correcta"
        Unload Me
    End If
End Sub

Sub borrar()
    On Error GoTo FALLO
    bd.Refresh
    bd.Recordset.MoveFirst
    Do
        bd.Recordset.Delete
        bd.Recordset.MoveNext
    Loop While bd.Recordset.EOF = False
    
    Call nuevoregvacio
    bd.Refresh
    bd.Recordset.FindFirst ("Observaciones='Borreme'")
    bd.Recordset.Delete
    bd.Recordset.MoveFirst
    MsgBox "Base de Datos Reinicializada", vbExclamation
    GoTo SIGUE
    
FALLO:
    Select Case Err.Number
        Case 3021
            MsgBox "No Hay Ningun registro"
    End Select
    
SIGUE:
    
End Sub

Private Sub Form_Load()
bd.Refresh
End Sub

Private Sub txtllave2_Change()
If txtllave2.Text = txtllave.Caption Then
    botseguir.Enabled = True
End If

End Sub

Private Sub txtllave3_Change()
    If Len(txtllave3.Text) > 8 Then
        botseguir.Enabled = True
    Else
        botseguir.Enabled = False
    End If
    
End Sub
Sub nuevoregvacio()

Call frmFrecuencias.SituarBD
bd.Refresh
bd.Recordset.AddNew
bd.Recordset("Registro") = 0
bd.Recordset("frecuencia") = "000.000"
bd.Recordset("Memoria") = 0
bd.Recordset("Observaciones") = "Borreme"
bd.Recordset("Localidad") = "Borreme"
bd.Recordset("Banda") = "2 m"
bd.Recordset("Fecha") = Date
bd.Recordset("Comprobado") = False
bd.Recordset("Exportar") = False
bd.Recordset.Update

End Sub
