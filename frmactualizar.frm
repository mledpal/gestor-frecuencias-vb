VERSION 5.00
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "Comctl32.ocx"
Object = "{67397AA1-7FB1-11D0-B148-00A0C922E820}#6.0#0"; "MSADODC.OCX"
Begin VB.Form frmactualizar 
   Caption         =   "Actualización por Internet"
   ClientHeight    =   2445
   ClientLeft      =   60
   ClientTop       =   450
   ClientWidth     =   5055
   LinkTopic       =   "Form1"
   ScaleHeight     =   2445
   ScaleWidth      =   5055
   StartUpPosition =   2  'CenterScreen
   Begin ComctlLib.ProgressBar PB 
      Align           =   2  'Align Bottom
      Height          =   375
      Left            =   0
      TabIndex        =   12
      Top             =   1395
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   661
      _Version        =   327682
      Appearance      =   1
   End
   Begin MSAdodcLib.Adodc BDR 
      Align           =   2  'Align Bottom
      Height          =   330
      Left            =   0
      Top             =   1770
      Visible         =   0   'False
      Width           =   5055
      _ExtentX        =   8916
      _ExtentY        =   582
      ConnectMode     =   0
      CursorLocation  =   3
      IsolationLevel  =   -1
      ConnectionTimeout=   15
      CommandTimeout  =   30
      CursorType      =   3
      LockType        =   3
      CommandType     =   8
      CursorOptions   =   0
      CacheSize       =   50
      MaxRecords      =   0
      BOFAction       =   0
      EOFAction       =   0
      ConnectStringType=   1
      Appearance      =   1
      BackColor       =   -2147483643
      ForeColor       =   -2147483640
      Orientation     =   0
      Enabled         =   -1
      Connect         =   ""
      OLEDBString     =   ""
      OLEDBFile       =   ""
      DataSourceName  =   ""
      OtherAttributes =   ""
      UserName        =   ""
      Password        =   ""
      RecordSource    =   "Select * From Frecuencias Order by Registro"
      Caption         =   "Base de Datos Remota"
      BeginProperty Font {0BE35203-8F91-11CE-9DE3-00AA004BB851} 
         Name            =   "MS Sans Serif"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      _Version        =   393216
   End
   Begin VB.CommandButton botsalir 
      Caption         =   "Salir"
      Height          =   375
      Left            =   3480
      TabIndex        =   11
      Top             =   1680
      Width           =   1455
   End
   Begin VB.CommandButton botactualizar 
      Caption         =   "Actualizar"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3480
      TabIndex        =   10
      Top             =   1200
      Width           =   1455
   End
   Begin VB.CommandButton botcomprobar 
      Caption         =   "Comprobar BD"
      Enabled         =   0   'False
      Height          =   375
      Left            =   3480
      TabIndex        =   9
      Top             =   720
      Width           =   1455
   End
   Begin VB.CommandButton botconectar 
      Caption         =   "Conectar"
      Height          =   375
      Left            =   3480
      TabIndex        =   8
      Top             =   240
      Width           =   1455
   End
   Begin VB.CommandButton botprobar 
      Caption         =   "Probar Conexión"
      Height          =   255
      Left            =   960
      TabIndex        =   7
      Top             =   1680
      Width           =   1455
   End
   Begin VB.Frame Frame1 
      Caption         =   "Datos de Conexión"
      Height          =   1935
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   3255
      Begin VB.TextBox txtservidor 
         Height          =   285
         Left            =   1080
         TabIndex        =   6
         Top             =   1080
         Width           =   2055
      End
      Begin VB.TextBox txtpassword 
         Height          =   285
         IMEMode         =   3  'DISABLE
         Left            =   1080
         PasswordChar    =   "*"
         TabIndex        =   5
         Top             =   720
         Width           =   2055
      End
      Begin VB.TextBox txtusuario 
         Height          =   285
         Left            =   1080
         TabIndex        =   4
         Top             =   360
         Width           =   2055
      End
      Begin VB.Label Label3 
         Caption         =   "Servidor :"
         Height          =   255
         Left            =   120
         TabIndex        =   3
         Top             =   1080
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Password:"
         Height          =   255
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Usuario:"
         Height          =   255
         Left            =   120
         TabIndex        =   1
         Top             =   360
         Width           =   615
      End
   End
   Begin VB.Data bd 
      Align           =   2  'Align Bottom
      Caption         =   "Base de Datos Local"
      Connect         =   "Access 2000;"
      DatabaseName    =   "D:\Programacion\Frecuencias\frecuencias.mdb"
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   345
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Frecuencias"
      Top             =   2100
      Visible         =   0   'False
      Width           =   5055
   End
End
Attribute VB_Name = "frmactualizar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub botactualizar_Click()
    
    On Error Resume Next
    
    Call frmFrecuencias.SituarBD
    Dim Frec, Criterio As String
    Dim nuevos, viejos, total As Integer
        
    BDR.Recordset.MoveFirst
    PB.Max = BDR.Recordset.RecordCount
    For n = 1 To BDR.Recordset.RecordCount
        
        Frec = BDR.Recordset("Frecuencia")
        Criterio = "Frecuencia=" + Chr(39) + CStr(Frec) + Chr(39)
        bd.Recordset.FindFirst Criterio
                       
            If bd.Recordset.NoMatch Then
                bd.Recordset.AddNew
                    bd.Recordset("Frecuencia") = BDR.Recordset("Frecuencia")
                    bd.Recordset("Memoria") = CInt(BDR.Recordset("Memoria"))
                    bd.Recordset("Observaciones") = BDR.Recordset("Observaciones")
                    bd.Recordset("Localidad") = BDR.Recordset("Localidad")
                    bd.Recordset("Banda") = BDR.Recordset("Banda")
                    bd.Recordset("Fecha") = BDR.Recordset("Fecha")
                    bd.Recordset("Exportar") = BDR.Recordset("Exportar")
                    bd.Recordset("Comprobado") = BDR.Recordset("Comprobado")
                    bd.Recordset("Mhz") = BDR.Recordset("Mhz")
                    bd.Recordset("Khz") = BDR.Recordset("Khz")
                    bd.Recordset("S") = CInt(BDR.Recordset("S"))
                    bd.Recordset("R") = CInt(BDR.Recordset("R"))
                    bd.Recordset("CTCSS") = BDR.Recordset("CTCSS")
                    bd.Recordset("DCS") = BDR.Recordset("DCS")
                bd.Recordset.Update
                nuevos = nuevos + 1
            Else
                viejos = viejos + 1
            End If
            
            total = total + 1
            PB.Value = total
          BDR.Recordset.MoveNext
    
    Next n

    Call frmFrecuencias.SituarBD
    bd.Refresh
    
    Call frmOptions.botorden_Click
    MsgBox "Base de datos actualizada con éxito. Se han añadido " + CStr(nuevos) + " registros."
    Unload Me
    Unload frmOptions
End Sub

Private Sub botcomprobar_Click()
    bd.Refresh
    BDR.Refresh
        On Error Resume Next
    
    Call frmFrecuencias.SituarBD
    Dim Frec, Criterio As String
    Dim nuevos, viejos, total As Integer
        
    BDR.Recordset.MoveFirst
    PB.Max = BDR.Recordset.RecordCount
    For n = 1 To BDR.Recordset.RecordCount
        
        Frec = BDR.Recordset("Frecuencia")
        Criterio = "Frecuencia=" + Chr(39) + CStr(Frec) + Chr(39)
        bd.Recordset.FindFirst Criterio
                       
            If bd.Recordset.NoMatch Then
                nuevos = nuevos + 1
            Else
                viejos = viejos + 1
            End If
            
            total = total + 1
            PB.Value = total
          BDR.Recordset.MoveNext
    
    Next n
    If nuevos > 0 Then
        MsgBox "Se han encontrado " + CStr(nuevos) + " nuevas frecuencias.", vbInformation
    Else
        MsgBox "No se han encontrado frecuencias nuevas en el servidor"
        botactualizar.Enabled = False
    End If
        PB.Value = 0
End Sub

Private Sub botconectar_Click()
    On Error Resume Next
    BDR.ConnectionString = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=" + CStr(txtservidor.Text) + "; DATABASE=frecuencias; UID=" + CStr(txtusuario.Text) + "; PWD=" + CStr(txtpassword.Text) + ";"
    BDR.Refresh
    If BDR.Recordset.RecordCount > 0 Then
        MsgBox "CONECTADO a base de datos con : " + CStr(BDR.Recordset.RecordCount) + " registros"
        botcomprobar.Enabled = True
        botactualizar.Enabled = True
    Else
        MsgBox "Error en acceso a base de datos", vbExclamation
    End If
    
End Sub

Private Sub botprobar_Click()
    On Error GoTo Fallo_conexion
        BDR.ConnectionString = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=" + CStr(txtservidor.Text) + "; DATABASE=frecuencias; UID=" + CStr(txtusuario.Text) + "; PWD=" + CStr(txtpassword.Text) + ";"
        BDR.Refresh
        MsgBox "Conexion OK. La base de datos contiene " + CStr(BDR.Recordset.RecordCount) + " registros."
        Exit Sub
Fallo_conexion:
    MsgBox Err.Description, vbInformation
End Sub

Private Sub botsalir_Click()
    frmOptions.Show modal
    Unload Me
End Sub

