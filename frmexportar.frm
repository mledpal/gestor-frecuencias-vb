VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "Comctl32.ocx"
Begin VB.Form frmexportar 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Exportar Registros"
   ClientHeight    =   4275
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   7605
   LinkTopic       =   "Exportar"
   MaxButton       =   0   'False
   Moveable        =   0   'False
   ScaleHeight     =   4275
   ScaleWidth      =   7605
   StartUpPosition =   2  'CenterScreen
   Begin ComctlLib.ProgressBar PB 
      Height          =   375
      Left            =   4320
      TabIndex        =   40
      Top             =   3840
      Width           =   3135
      _ExtentX        =   5530
      _ExtentY        =   661
      _Version        =   327682
      Appearance      =   1
   End
   Begin VB.Data BD 
      Caption         =   "Frecuencias"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   -1  'True
      Height          =   375
      Left            =   2880
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Frecuencias"
      Top             =   3360
      Width           =   4725
   End
   Begin VB.CommandButton botgenerar 
      Caption         =   "GENERAR TXT"
      Height          =   375
      Left            =   2880
      TabIndex        =   37
      Top             =   3840
      Width           =   1335
   End
   Begin VB.Frame fraexportar 
      Caption         =   "Exportar . . ."
      Height          =   1695
      Left            =   0
      TabIndex        =   31
      Top             =   2520
      Width           =   2775
      Begin VB.Frame fraseleccion 
         Caption         =   "Seleccionar"
         Height          =   855
         Left            =   120
         TabIndex        =   34
         Top             =   720
         Width           =   2535
         Begin VB.CheckBox chkexport 
            Caption         =   "Exportar"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1440
            Style           =   1  'Graphical
            TabIndex        =   36
            Top             =   360
            Width           =   975
         End
         Begin VB.CheckBox chkcomprob 
            Caption         =   "Comprobado"
            Enabled         =   0   'False
            Height          =   375
            Left            =   120
            Style           =   1  'Graphical
            TabIndex        =   35
            Top             =   360
            Width           =   1215
         End
      End
      Begin VB.OptionButton optseleccionar 
         Caption         =   "Seleccionados"
         Height          =   375
         Left            =   1080
         Style           =   1  'Graphical
         TabIndex        =   33
         Top             =   240
         Width           =   1455
      End
      Begin VB.OptionButton opttodos 
         Caption         =   "Todos"
         Height          =   375
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   32
         Top             =   240
         Value           =   -1  'True
         Width           =   855
      End
   End
   Begin VB.Frame Registro 
      Caption         =   "Registro"
      Height          =   3735
      Left            =   2880
      TabIndex        =   10
      Top             =   0
      Width           =   4695
      Begin VB.CommandButton botmem 
         Caption         =   "Mem"
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
         Left            =   3360
         TabIndex        =   28
         Top             =   840
         Width           =   1215
      End
      Begin VB.CheckBox chkexportar 
         Caption         =   "Exportar"
         DataField       =   "Exportar"
         DataSource      =   "BD"
         Height          =   375
         Left            =   3360
         TabIndex        =   25
         Top             =   3000
         Width           =   975
      End
      Begin VB.TextBox txtFrecuencia 
         DataField       =   "Frecuencia"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         Locked          =   -1  'True
         TabIndex        =   18
         Top             =   360
         Width           =   1815
      End
      Begin VB.TextBox TxtLocalidad 
         DataField       =   "Localidad"
         DataSource      =   "BD"
         Height          =   375
         Left            =   960
         Locked          =   -1  'True
         TabIndex        =   17
         Top             =   2640
         Width           =   1695
      End
      Begin VB.TextBox TxtObserv 
         DataField       =   "Observaciones"
         DataSource      =   "BD"
         Height          =   615
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   50
         MultiLine       =   -1  'True
         TabIndex        =   16
         Top             =   1320
         Width           =   3135
      End
      Begin VB.TextBox TxtMemoria 
         DataField       =   "Memoria"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         Locked          =   -1  'True
         MaxLength       =   2
         TabIndex        =   15
         Top             =   840
         Width           =   1815
      End
      Begin VB.ComboBox TxtBanda 
         DataField       =   "Banda"
         DataSource      =   "BD"
         Height          =   315
         ItemData        =   "frmexportar.frx":0000
         Left            =   3360
         List            =   "frmexportar.frx":001F
         Locked          =   -1  'True
         Sorted          =   -1  'True
         TabIndex        =   14
         Top             =   2640
         Width           =   1215
      End
      Begin VB.TextBox txtfecha 
         DataField       =   "Fecha"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         Locked          =   -1  'True
         TabIndex        =   13
         Top             =   2040
         Width           =   1095
      End
      Begin VB.CommandButton botrepet 
         Caption         =   "+ R -"
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
         Left            =   3360
         TabIndex        =   12
         Top             =   360
         Width           =   1215
      End
      Begin VB.CheckBox chkcomprobado 
         Caption         =   "Comprobada"
         DataField       =   "Comprobado"
         DataSource      =   "BD"
         Height          =   375
         Left            =   3360
         TabIndex        =   11
         Top             =   2040
         Width           =   1215
      End
      Begin VB.Label Lbl1 
         Caption         =   "Frecuencia  :"
         Height          =   255
         Left            =   360
         TabIndex        =   24
         Top             =   360
         Width           =   975
      End
      Begin VB.Label Lbl2 
         Caption         =   "Memoria :"
         Height          =   255
         Left            =   600
         TabIndex        =   23
         Top             =   840
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Observaciones :"
         Height          =   255
         Left            =   120
         TabIndex        =   22
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "Localidad :"
         Height          =   255
         Left            =   120
         TabIndex        =   21
         Top             =   2640
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Banda :"
         Height          =   255
         Left            =   2760
         TabIndex        =   20
         Top             =   2640
         Width           =   615
      End
      Begin VB.Label Label6 
         Caption         =   "Fecha :"
         Height          =   255
         Left            =   720
         TabIndex        =   19
         Top             =   2040
         Width           =   615
      End
   End
   Begin VB.Frame NumeroReg 
      Caption         =   "Registros"
      Height          =   2415
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   2775
      Begin VB.CommandButton botvercomp 
         Caption         =   ">"
         Height          =   255
         Left            =   1680
         TabIndex        =   39
         Top             =   1080
         Width           =   255
      End
      Begin VB.CommandButton botselexporta 
         Caption         =   "N"
         Height          =   255
         Index           =   1
         Left            =   2040
         TabIndex        =   30
         Top             =   1440
         Width           =   255
      End
      Begin VB.CommandButton botselexporta 
         Caption         =   "T"
         Height          =   255
         Index           =   0
         Left            =   1680
         TabIndex        =   29
         Top             =   1440
         Width           =   255
      End
      Begin VB.TextBox txtexportar 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         ForeColor       =   &H00FF0000&
         Height          =   285
         Left            =   960
         Locked          =   -1  'True
         TabIndex        =   26
         Top             =   1440
         Width           =   615
      End
      Begin VB.TextBox RegActual 
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
         Left            =   960
         Locked          =   -1  'True
         TabIndex        =   5
         Top             =   240
         Width           =   975
      End
      Begin VB.TextBox RegTotal 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00FF0000&
         Height          =   285
         Left            =   960
         Locked          =   -1  'True
         TabIndex        =   4
         Top             =   1920
         Width           =   975
      End
      Begin VB.TextBox txtira 
         Alignment       =   2  'Center
         Height          =   255
         Left            =   960
         MaxLength       =   5
         TabIndex        =   3
         Top             =   600
         Width           =   615
      End
      Begin VB.CommandButton botir 
         Caption         =   ">"
         Enabled         =   0   'False
         Height          =   255
         Left            =   1680
         TabIndex        =   2
         Top             =   600
         Width           =   255
      End
      Begin VB.TextBox txtComprobado 
         Alignment       =   2  'Center
         BackColor       =   &H80000018&
         ForeColor       =   &H00FF0000&
         Height          =   285
         Left            =   960
         Locked          =   -1  'True
         TabIndex        =   1
         Top             =   1080
         Width           =   615
      End
      Begin VB.Label Label9 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Export"
         Height          =   195
         Left            =   360
         TabIndex        =   27
         Top             =   1440
         Width           =   465
      End
      Begin VB.Label Label4 
         Caption         =   "Numero:"
         Height          =   255
         Left            =   360
         TabIndex        =   9
         Top             =   240
         Width           =   615
      End
      Begin VB.Label Label5 
         Caption         =   "Total :"
         Height          =   255
         Left            =   360
         TabIndex        =   8
         Top             =   1920
         Width           =   495
      End
      Begin VB.Label Label7 
         Caption         =   "Ir a :"
         Height          =   255
         Left            =   600
         TabIndex        =   7
         Top             =   600
         Width           =   375
      End
      Begin VB.Label Label8 
         Alignment       =   2  'Center
         AutoSize        =   -1  'True
         Caption         =   "Compr"
         Height          =   195
         Left            =   360
         TabIndex        =   6
         Top             =   1080
         Width           =   465
      End
   End
   Begin MSComDlg.CommonDialog dialogo 
      Left            =   0
      Top             =   0
      _ExtentX        =   847
      _ExtentY        =   847
      _Version        =   393216
      CancelError     =   -1  'True
      DefaultExt      =   "RGF"
      FileName        =   "Frecuencias.rgf"
      Filter          =   "LOG | *.log ; Registro | *.rgf"
      FilterIndex     =   2
      InitDir         =   "C:\"
   End
   Begin VB.Label Label10 
      AutoSize        =   -1  'True
      Caption         =   "Actualizando Datos"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   435
      Left            =   3600
      TabIndex        =   38
      Top             =   1440
      Width           =   3345
   End
End
Attribute VB_Name = "frmexportar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Valor As Boolean
Dim TXT As Registro
Dim regprogram As Integer


Private Sub botgenerar_Click()

    dialogo.ShowSave
    If dialogo.FileName = "" Or dialogo.FileName = Null Then
        MsgBox "Nombre de Archivo no Válido", vbCritical
        Exit Sub
    End If
         
    If opttodos.Value = True Then
        Call Exportar(0)
    End If
    
    If optseleccionar.Value = True Then
           
        If chkexport.Value = 1 And chkcomprob.Value = 0 Then
            Call Exportar(1)
            Exit Sub
        End If
        
        If chkexport.Value = 0 And chkcomprob.Value = 1 Then
            Call Exportar(2)
            Exit Sub
        End If
        
        If chkexport.Value = 1 And chkcomprob.Value = 1 Then
            Call Exportar(3)
            Exit Sub
        End If
        
        If chkcomprob.Value = 0 And chkexport.Value = 0 Then
            MsgBox "Debe Seleccionar alguna opción para ejecutar esta opcion", vbCritical
            Exit Sub
        End If
    End If
    
    MsgBox "Archivo Creado Con Éxito", vbInformation
    Unload Me
    frmFrecuencias.Show
End Sub

Private Sub botmem_Click()
frmmapamemoria.Show (modal)
End Sub

Private Sub botselexporta_Click(Index As Integer)
Registro.Visible = False
Select Case Index
    Case 0
        Valor = True
    Case 1
        Valor = False
End Select

bd.Recordset.MoveFirst
Do
    bd.Recordset.Edit
    bd.Recordset("Exportar") = Valor
    bd.Recordset.Update
    
    bd.Recordset.MoveNext
Loop While Not bd.Recordset.EOF
Call Form_Activate

End Sub

Private Sub botrepet_Click()
cadena = Right(txtFrecuencia.Text, 9)
cadena = Left(cadena, 8)
Modulo.grabarFrec (cadena)
frmrepetidores.Show (modal)
End Sub

Private Sub bottodos_Click()
bd.Recordset.MoveFirst
Do
    bd.Recordset("Exportar") = True
    bd.Recordset.MoveNext
Loop While Not bd.Recordset.EOF
Call Form_Activate
End Sub

Private Sub botvercomp_Click()
cadenabusqueda = "Comprobado=True"
Modulo.grabar (cadenabusqueda)
frmResultados.Show
Unload Me
End Sub

Private Sub chkexportar_MouseDown(Button As Integer, Shift As Integer, x As Single, y As Single)
bd.Recordset.Edit
bd.Recordset("Exportar") = chkexportar.Value
bd.Recordset.Update
Call Form_Activate
End Sub

Sub Form_Activate()

Registro.Visible = False
On Error Resume Next
Call frmFrecuencias.SituarBD
bd.Refresh
Call SumarRegistros
bd.Refresh
bd.Recordset.MoveLast
bd.Recordset.MoveFirst
Registro.Visible = True

End Sub

Private Sub BD_Reposition()
RegTotal.Text = bd.Recordset.RecordCount
End Sub


Private Sub optseleccionar_Click()

If optseleccionar.Value = True Then
    chkcomprob.Enabled = True
    chkexport.Enabled = True
End If

End Sub

Private Sub opttodos_Click()
If opttodos.Value = True Then
    chkcomprob.Enabled = False
    chkexport.Enabled = False
    chkcomprob.Value = 0
    chkexport.Value = 0
End If
End Sub

Private Sub txtira_Change()
botir.Enabled = True
botir.Default = True
End Sub
Private Sub botir_Click()
If Len(txtira.Text) > 0 And IsNumeric(txtira.Text) Then
    Criterio = "Registro=" + txtira.Text
    bd.Recordset.FindFirst Criterio
    
    If bd.Recordset.NoMatch = True Then
        MsgBox "No Existe el Registro Indicado", vbCritical
    End If
Else
    MsgBox "Valor Introducido No Válido", vbCritical
End If
txtira.Text = ""
botir.Enabled = False
End Sub

Sub SumarRegistros()
bd.Recordset.MoveFirst
n = 0
e = 0

Do
    If bd.Recordset("Comprobado") = True Then n = n + 1
    If bd.Recordset("Exportar") = True Then e = e + 1
    bd.Recordset.MoveNext
Loop While Not bd.Recordset.EOF

txtComprobado.Text = n
txtexportar.Text = e
bd.Recordset.MoveFirst
End Sub

Sub Exportar(Seleccion As Byte)
Registro.Visible = False

Open dialogo.FileName For Binary As #1
regprogram = 7980
Put #1, , regprogram

reg = 0
n = 0
bd.Recordset.MoveLast
PB.Max = bd.Recordset.RecordCount
bd.Recordset.MoveFirst


Select Case Seleccion
    Case 0 ' Exportar Todos
    
    n = 1
        Do
            PB.Value = n
            Call BD_A_TxT
            Put #1, , TXT
            bd.Recordset.MoveNext
            n = n + 1
        Loop While Not bd.Recordset.EOF
    PB.Value = 0
    
    Case 1 ' Exportar Seleccionados
        cadenabusqueda = "Exportar=True"
        bd.Recordset.FindFirst cadenabusqueda
        
        Do While Not bd.Recordset.NoMatch
            Call BD_A_TxT
            Put #1, , TXT
            bd.Recordset.FindNext cadenabusqueda
        Loop
        
    Case 2 ' Exportar Frecuencias Comprobadas
        cadenabusqueda = "Comprobado=True"
        bd.Recordset.FindFirst cadenabusqueda
        
        Do While Not bd.Recordset.NoMatch
            Call BD_A_TxT
            Put #1, , TXT
            bd.Recordset.FindNext cadenabusqueda
        Loop
    
    Case 3 ' Exportar Frecuencias Comprobadas y Seleccionadas
        cadenabusqueda = "Comprobado=True and Exportar=True"
        bd.Recordset.FindFirst cadenabusqueda
        
        Do While Not bd.Recordset.NoMatch
            Call BD_A_TxT
            Put #1, , TXT
            bd.Recordset.FindNext cadenabusqueda
        Loop
           
End Select

TXT.Registro = 0
TXT.Observaciones = "FIN"
Put #1, , TXT
Close #1

Registro.Visible = True
Call Form_Activate
End Sub

Sub BD_A_TxT()
    On Error Resume Next
    
    reg = reg + 1
    TXT.Registro = bd.Recordset("Registro")
    TXT.Fecha = bd.Recordset("Fecha")
    TXT.Frecuencia = bd.Recordset("Frecuencia")
    TXT.MEMORIA = bd.Recordset("Memoria")
    TXT.Localidad = bd.Recordset("Localidad")
    TXT.Observaciones = bd.Recordset("Observaciones")
    TXT.Banda = bd.Recordset("Banda")
    TXT.Comprobado = bd.Recordset("Comprobado")
    TXT.Exportar = bd.Recordset("Exportar")
    
End Sub
