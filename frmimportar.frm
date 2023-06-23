VERSION 5.00
Object = "{F9043C88-F6F2-101A-A3C9-08002B2F49FB}#1.2#0"; "Comdlg32.ocx"
Object = "{6B7E6392-850A-101B-AFC0-4210102A8DA7}#1.3#0"; "Comctl32.ocx"
Begin VB.Form frmimportar 
   Caption         =   "Añadir  Registros"
   ClientHeight    =   2205
   ClientLeft      =   60
   ClientTop       =   345
   ClientWidth     =   3165
   LinkTopic       =   "Form1"
   ScaleHeight     =   2205
   ScaleWidth      =   3165
   StartUpPosition =   3  'Windows Default
   Begin VB.Data bd 
      Caption         =   "BD"
      Connect         =   "Access 2000;"
      DatabaseName    =   ""
      DefaultCursorType=   0  'DefaultCursor
      DefaultType     =   2  'UseODBC
      Exclusive       =   0   'False
      Height          =   300
      Left            =   0
      Options         =   0
      ReadOnly        =   0   'False
      RecordsetType   =   1  'Dynaset
      RecordSource    =   "Frecuencias"
      Top             =   1920
      Visible         =   0   'False
      Width           =   1140
   End
   Begin ComctlLib.ProgressBar PB 
      Height          =   975
      Left            =   2760
      TabIndex        =   7
      Top             =   240
      Width           =   255
      _ExtentX        =   450
      _ExtentY        =   1720
      _Version        =   327682
      Appearance      =   1
   End
   Begin VB.Frame fraexportar 
      Caption         =   "Importar . . ."
      Height          =   1695
      Left            =   0
      TabIndex        =   1
      Top             =   0
      Width           =   2775
      Begin VB.OptionButton opttodos 
         Caption         =   "Todos"
         Height          =   375
         Left            =   120
         Style           =   1  'Graphical
         TabIndex        =   6
         Top             =   240
         Value           =   -1  'True
         Width           =   855
      End
      Begin VB.OptionButton optseleccionar 
         Caption         =   "Seleccionados"
         Height          =   375
         Left            =   1200
         Style           =   1  'Graphical
         TabIndex        =   5
         Top             =   240
         Width           =   1455
      End
      Begin VB.Frame fraseleccion 
         Caption         =   "Seleccionar"
         Height          =   855
         Left            =   120
         TabIndex        =   2
         Top             =   720
         Width           =   2535
         Begin VB.CheckBox chkcomprob 
            Caption         =   "Comprobado"
            Enabled         =   0   'False
            Height          =   375
            Left            =   120
            Style           =   1  'Graphical
            TabIndex        =   4
            Top             =   360
            Width           =   1215
         End
         Begin VB.CheckBox chkexport 
            Caption         =   "Exportar"
            Enabled         =   0   'False
            Height          =   375
            Left            =   1440
            Style           =   1  'Graphical
            TabIndex        =   3
            Top             =   360
            Width           =   975
         End
      End
   End
   Begin VB.CommandButton botimportar 
      Caption         =   "IMPORTAR TXT"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   1800
      Width           =   2655
   End
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
Attribute VB_Name = "frmimportar"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim regprogram As Integer
Dim TXT As Registro
Dim NRegistros As Long

Private Sub botimportar_Click()
NRegistros = 0
bd.Refresh

Dim Mensaje, Estilo, Título, Ayuda, Ctxt, Respuesta, MiCadena
Mensaje = "¿Desea continuar?"
Estilo = vbYesNo + vbInformation + vbDefaultButton1
Título = "Añadir Registros a Base De Datos"
Respuesta = MsgBox(Mensaje, Estilo, Título, Ayuda, Ctxt)

If Respuesta = vbYes Then
    dialogo.ShowOpen
    If dialogo.FileName = "" Then Exit Sub

    Open dialogo.FileName For Binary As #1 ' 1º Abre
    Get #1, , regprogram
    Close #1 ' 1º Cierra
    
    If regprogram = 7980 Then
        MsgBox "Clave de archivo de Seguridad Valida. Se procede a la carga . . ."
        Call descargar(1)
        Close
        Exit Sub
    Else
        MsgBox "Archivo no válido, clave de seguridad incorrecta o acción cancelada"
    End If
Else
MsgBox "Accion Cancelada", vbInformation
End If
Unload Me
frmFrecuencias.Show

End Sub

Sub descargar(Tipo As Byte)
    On Error Resume Next
' Tipo = 0 Cargar
' Tipo = 1 Añadir

    bd.Refresh
    
    Select Case Tipo
        Case 0
            opttodos = True
            Open dialogo.FileName For Binary As #1
            Get #1, , regprogram
            Close
        Case 1
            bd.Recordset.MoveLast
            If Not bd.Recordset("Registro") Then
                reg = CInt(bd.Recordset("Registro"))
            Else
                reg = 0
            End If
            
            Open dialogo.FileName For Binary As #1
            Get #1, , regprogram
            Close
    End Select
    
    If opttodos = True Then
        Call Importar(0) ' Importar Todos
    End If
    
    If optseleccionar = True Then
        If chkcomprob.Value = 1 And chkexport.Value = 0 Then
            Call Importar(1) ' Solo Los Comprobados
        End If
        If chkcomprob.Value = 0 And chkexport.Value = 1 Then
            Call Importar(2) ' Solo los Exportables
        End If
        If chkcomprob.Value = 1 And chkexport.Value = 1 Then
            Call Importar(3) ' Todos los Comprobados y Exportables
        Else
            MsgBox "Seleccione alguna opcion", vbInformation
        End If
    End If
    
    Close #1
    
    
    bd.Recordset.MoveLast
    bd.Recordset.Delete
    
    MsgBox "Importación realizada con éxito", vbInformation
    
    
    Unload Me
    frmFrecuencias.Show
End Sub

Sub Importar(Condicion As Byte)
Close
Open dialogo.FileName For Binary As #1
Get #1, , regprogram

    Do
        Get #1, , TXT
        If TXT.Observaciones = "FIN" Then Exit Sub
        
        NRegistros = NRegistros + 1
        
        bd.Recordset.AddNew
        
        bd.Recordset("Registro") = NRegistros
        bd.Recordset("Fecha") = TXT.Fecha
        
        bd.Recordset("Frecuencia") = Trim(TXT.Frecuencia)
        bd.Recordset("Memoria") = TXT.MEMORIA
        bd.Recordset("Localidad") = Trim(TXT.Localidad)
        bd.Recordset("Observaciones") = Trim(TXT.Observaciones)
        bd.Recordset("Banda") = Trim(TXT.Banda)
        bd.Recordset("Comprobado") = TXT.Comprobado
        bd.Recordset("Exportar") = TXT.Exportar
        
        bd.Recordset.Update
        
    Loop While Not EOF(1)

End Sub



