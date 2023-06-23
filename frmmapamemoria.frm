VERSION 5.00
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "COMCTL32.OCX"
Begin VB.Form frmmapamemoria 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Mapa de Memoria"
   ClientHeight    =   2385
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   3750
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   2385
   ScaleWidth      =   3750
   Begin ComctlLib.StatusBar BE 
      Align           =   2  'Align Bottom
      Height          =   255
      Left            =   0
      TabIndex        =   51
      Top             =   2130
      Width           =   3750
      _ExtentX        =   6615
      _ExtentY        =   450
      SimpleText      =   ""
      _Version        =   327682
      BeginProperty Panels {0713E89E-850A-101B-AFC0-4210102A8DA7} 
         NumPanels       =   2
         BeginProperty Panel1 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Alignment       =   1
            AutoSize        =   2
            TextSave        =   ""
            Key             =   ""
            Object.Tag             =   ""
         EndProperty
         BeginProperty Panel2 {0713E89F-850A-101B-AFC0-4210102A8DA7} 
            Alignment       =   1
            AutoSize        =   1
            Object.Width           =   3995
            TextSave        =   ""
            Key             =   ""
            Object.Tag             =   ""
         EndProperty
      EndProperty
   End
   Begin VB.Frame Frame1 
      Caption         =   "Mapa de Memoria del Escaner"
      Height          =   2055
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   3735
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "1"
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   50
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "2"
         Height          =   255
         Index           =   1
         Left            =   480
         TabIndex        =   49
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "3"
         Height          =   255
         Index           =   2
         Left            =   840
         TabIndex        =   48
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "4"
         Height          =   255
         Index           =   3
         Left            =   1200
         TabIndex        =   47
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "5"
         Height          =   255
         Index           =   4
         Left            =   1560
         TabIndex        =   46
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "6"
         Height          =   255
         Index           =   5
         Left            =   1920
         TabIndex        =   45
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "7"
         Height          =   255
         Index           =   6
         Left            =   2280
         TabIndex        =   44
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "8"
         Height          =   255
         Index           =   7
         Left            =   2640
         TabIndex        =   43
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "9"
         Height          =   255
         Index           =   8
         Left            =   3000
         TabIndex        =   42
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "10"
         Height          =   255
         Index           =   9
         Left            =   3360
         TabIndex        =   41
         Top             =   240
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "11"
         Height          =   255
         Index           =   10
         Left            =   120
         TabIndex        =   40
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "12"
         Height          =   255
         Index           =   11
         Left            =   480
         TabIndex        =   39
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "13"
         Height          =   255
         Index           =   12
         Left            =   840
         TabIndex        =   38
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "14"
         Height          =   255
         Index           =   13
         Left            =   1200
         TabIndex        =   37
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "15"
         Height          =   255
         Index           =   14
         Left            =   1560
         TabIndex        =   36
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "16"
         Height          =   255
         Index           =   15
         Left            =   1920
         TabIndex        =   35
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "17"
         Height          =   255
         Index           =   16
         Left            =   2280
         TabIndex        =   34
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "18"
         Height          =   255
         Index           =   17
         Left            =   2640
         TabIndex        =   33
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "19"
         Height          =   255
         Index           =   18
         Left            =   3000
         TabIndex        =   32
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "20"
         Height          =   255
         Index           =   19
         Left            =   3360
         TabIndex        =   31
         Top             =   600
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "21"
         Height          =   255
         Index           =   20
         Left            =   120
         TabIndex        =   30
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "22"
         Height          =   255
         Index           =   21
         Left            =   480
         TabIndex        =   29
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "23"
         Height          =   255
         Index           =   22
         Left            =   840
         TabIndex        =   28
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "24"
         Height          =   255
         Index           =   23
         Left            =   1200
         TabIndex        =   27
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "25"
         Height          =   255
         Index           =   24
         Left            =   1560
         TabIndex        =   26
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "26"
         Height          =   255
         Index           =   25
         Left            =   1920
         TabIndex        =   25
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "27"
         Height          =   255
         Index           =   26
         Left            =   2280
         TabIndex        =   24
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "28"
         Height          =   255
         Index           =   27
         Left            =   2640
         TabIndex        =   23
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "29"
         Height          =   255
         Index           =   28
         Left            =   3000
         TabIndex        =   22
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "30"
         Height          =   255
         Index           =   29
         Left            =   3360
         TabIndex        =   21
         Top             =   960
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "31"
         Height          =   255
         Index           =   30
         Left            =   120
         TabIndex        =   20
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "32"
         Height          =   255
         Index           =   31
         Left            =   480
         TabIndex        =   19
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "33"
         Height          =   255
         Index           =   32
         Left            =   840
         TabIndex        =   18
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "34"
         Height          =   255
         Index           =   33
         Left            =   1200
         TabIndex        =   17
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "35"
         Height          =   255
         Index           =   34
         Left            =   1560
         TabIndex        =   16
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "36"
         Height          =   255
         Index           =   35
         Left            =   1920
         TabIndex        =   15
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "37"
         Height          =   255
         Index           =   36
         Left            =   2280
         TabIndex        =   14
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "38"
         Height          =   255
         Index           =   37
         Left            =   2640
         TabIndex        =   13
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "39"
         Height          =   255
         Index           =   38
         Left            =   3000
         TabIndex        =   12
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "40"
         Height          =   255
         Index           =   39
         Left            =   3360
         TabIndex        =   11
         Top             =   1320
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "41"
         Height          =   255
         Index           =   40
         Left            =   120
         TabIndex        =   10
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "42"
         Height          =   255
         Index           =   41
         Left            =   480
         TabIndex        =   9
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "43"
         Height          =   255
         Index           =   42
         Left            =   840
         TabIndex        =   8
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "44"
         Height          =   255
         Index           =   43
         Left            =   1200
         TabIndex        =   7
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "45"
         Height          =   255
         Index           =   44
         Left            =   1560
         TabIndex        =   6
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "46"
         Height          =   255
         Index           =   45
         Left            =   1920
         TabIndex        =   5
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "47"
         Height          =   255
         Index           =   46
         Left            =   2280
         TabIndex        =   4
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "48"
         Height          =   255
         Index           =   47
         Left            =   2640
         TabIndex        =   3
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "49"
         Height          =   255
         Index           =   48
         Left            =   3000
         TabIndex        =   2
         Top             =   1680
         Width           =   255
      End
      Begin VB.Label lblmemoria 
         Alignment       =   2  'Center
         Caption         =   "50"
         Height          =   255
         Index           =   49
         Left            =   3360
         TabIndex        =   1
         Top             =   1680
         Width           =   255
      End
   End
   Begin VB.Data BD 
      Align           =   1  'Align Top
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
      Top             =   0
      Visible         =   0   'False
      Width           =   3750
   End
End
Attribute VB_Name = "frmmapamemoria"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Form_Activate()
Call frmFrecuencias.SituarBD
BD.Refresh
libres = 0
ocupadas = 0
For m = 0 To 49
    cadena = "Memoria=" + Str(m + 1)
    BD.Recordset.FindFirst cadena
    If BD.Recordset.NoMatch = True Then
        libres = libres + 1
        lblmemoria(m).Font.Bold = True
        lblmemoria(m).ForeColor = vbBlue
    Else
        ocupadas = ocupadas + 1
        lblmemoria(m).ForeColor = vbRed
    End If
Next m
BE.Panels.Item(1).Text = "Libres :" + Str(libres)
BE.Panels.Item(2).Text = "Ocupadas :" + Str(ocupadas)
End Sub

Private Sub lblmemoria_Click(Index As Integer)
    cadenabusqueda = "Memoria=" + Str(Index + 1)
    BD.Recordset.FindFirst cadenabusqueda
    If BD.Recordset.NoMatch = False Then
        Modulo.grabar (cadenabusqueda)
        frmResultados.Show (modal)
    Else
        frmnuevo.TxtMemoria = CStr(Index + 1)
        frmnuevo.Show
    End If
End Sub

