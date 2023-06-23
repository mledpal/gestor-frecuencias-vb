VERSION 5.00
Begin VB.Form frmFrecuencias 
   BorderStyle     =   1  'Fixed Single
   ClientHeight    =   3390
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10230
   Icon            =   "frmMeter.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   3390
   ScaleWidth      =   10230
   StartUpPosition =   2  'CenterScreen
   Begin VB.ComboBox txtCodificado 
      DataField       =   "SECRA"
      DataSource      =   "bd"
      Height          =   315
      ItemData        =   "frmMeter.frx":030A
      Left            =   7560
      List            =   "frmMeter.frx":031D
      TabIndex        =   41
      Top             =   840
      Width           =   1215
   End
   Begin VB.ComboBox txtoffset 
      DataField       =   "offset"
      DataSource      =   "bd"
      Height          =   315
      ItemData        =   "frmMeter.frx":0344
      Left            =   8880
      List            =   "frmMeter.frx":0369
      TabIndex        =   40
      Top             =   2040
      Width           =   1215
   End
   Begin VB.Frame registro 
      Caption         =   "Registro"
      Height          =   3015
      Index           =   0
      Left            =   2400
      TabIndex        =   14
      Top             =   0
      Width           =   7815
      Begin VB.CheckBox chkrepetidor 
         Caption         =   "Repetidor"
         DataField       =   "Repetidor"
         DataSource      =   "BD"
         Height          =   315
         Left            =   6480
         TabIndex        =   39
         Top             =   1560
         Width           =   1215
      End
      Begin VB.TextBox txtFrecuencia 
         DataField       =   "Frecuencia"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   28
         Top             =   360
         Width           =   1815
      End
      Begin VB.TextBox TxtLocalidad 
         DataField       =   "Localidad"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   27
         Top             =   2040
         Width           =   2415
      End
      Begin VB.TextBox TxtObserv 
         DataField       =   "Observaciones"
         DataSource      =   "BD"
         Height          =   615
         Left            =   1440
         MaxLength       =   100
         MultiLine       =   -1  'True
         TabIndex        =   26
         Top             =   1320
         Width           =   3135
      End
      Begin VB.TextBox TxtMemoria 
         DataField       =   "Memoria"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         MaxLength       =   2
         TabIndex        =   25
         Top             =   840
         Width           =   1815
      End
      Begin VB.ComboBox TxtBanda 
         DataField       =   "Banda"
         DataSource      =   "BD"
         Height          =   315
         ItemData        =   "frmMeter.frx":03C6
         Left            =   3360
         List            =   "frmMeter.frx":03E5
         Sorted          =   -1  'True
         TabIndex        =   24
         Top             =   2520
         Width           =   1215
      End
      Begin VB.TextBox txtfecha 
         DataField       =   "Fecha"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   23
         Top             =   2520
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
         TabIndex        =   22
         Top             =   360
         Width           =   1215
      End
      Begin VB.CheckBox chkcomprobado 
         Caption         =   "Comprobada"
         DataField       =   "Comprobado"
         DataSource      =   "BD"
         Height          =   315
         Left            =   6480
         TabIndex        =   21
         Top             =   120
         Width           =   1215
      End
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
         TabIndex        =   20
         Top             =   840
         Width           =   1215
      End
      Begin VB.TextBox txtr 
         Alignment       =   2  'Center
         DataField       =   "r"
         DataSource      =   "BD"
         Height          =   285
         Left            =   5640
         TabIndex        =   19
         Top             =   360
         Width           =   375
      End
      Begin VB.TextBox txts 
         Alignment       =   2  'Center
         DataField       =   "s"
         DataSource      =   "BD"
         Height          =   285
         Left            =   5160
         TabIndex        =   18
         Top             =   360
         Width           =   375
      End
      Begin VB.ComboBox txtctcss 
         DataField       =   "CTCSS"
         DataSource      =   "bd"
         Height          =   315
         ItemData        =   "frmMeter.frx":041D
         Left            =   5400
         List            =   "frmMeter.frx":04BD
         TabIndex        =   17
         Top             =   1560
         Width           =   855
      End
      Begin VB.ComboBox txtdcs 
         DataField       =   "dcs"
         DataSource      =   "bd"
         Height          =   315
         ItemData        =   "frmMeter.frx":0621
         Left            =   5400
         List            =   "frmMeter.frx":0763
         TabIndex        =   16
         Top             =   2040
         Width           =   855
      End
      Begin VB.ComboBox txtmodo 
         DataField       =   "Modo"
         DataSource      =   "BD"
         Height          =   315
         ItemData        =   "frmMeter.frx":097B
         Left            =   5400
         List            =   "frmMeter.frx":099A
         Sorted          =   -1  'True
         TabIndex        =   15
         Top             =   2520
         Width           =   855
      End
      Begin VB.Label Label9 
         Caption         =   "COD"
         Height          =   255
         Left            =   4680
         TabIndex        =   42
         Top             =   840
         Width           =   495
      End
      Begin VB.Label Lbl1 
         Caption         =   "Frecuencia  :"
         Height          =   255
         Left            =   360
         TabIndex        =   38
         Top             =   360
         Width           =   975
      End
      Begin VB.Label Lbl2 
         Caption         =   "Memoria :"
         Height          =   255
         Left            =   600
         TabIndex        =   37
         Top             =   840
         Width           =   735
      End
      Begin VB.Label Label2 
         Caption         =   "Observaciones :"
         Height          =   255
         Left            =   120
         TabIndex        =   36
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Label3 
         Caption         =   "Localidad :"
         Height          =   255
         Left            =   600
         TabIndex        =   35
         Top             =   2040
         Width           =   855
      End
      Begin VB.Label Label1 
         Caption         =   "Banda :"
         Height          =   255
         Left            =   2760
         TabIndex        =   34
         Top             =   2520
         Width           =   615
      End
      Begin VB.Label Label6 
         Caption         =   "Fecha :"
         Height          =   255
         Left            =   720
         TabIndex        =   33
         Top             =   2520
         Width           =   615
      End
      Begin VB.Label Label8 
         Caption         =   "S / R"
         Height          =   255
         Left            =   4680
         TabIndex        =   32
         Top             =   360
         Width           =   495
      End
      Begin VB.Label Label10 
         Caption         =   "CTCSS"
         Height          =   255
         Left            =   4680
         TabIndex        =   31
         Top             =   1560
         Width           =   615
      End
      Begin VB.Label Label11 
         Caption         =   "DCS"
         Height          =   255
         Left            =   4680
         TabIndex        =   30
         Top             =   2040
         Width           =   495
      End
      Begin VB.Label Label12 
         Caption         =   "Modo"
         Height          =   255
         Left            =   4680
         TabIndex        =   29
         Top             =   2520
         Width           =   615
      End
   End
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
      Top             =   3015
      Width           =   10230
   End
   Begin VB.CommandButton botopciones 
      Caption         =   "Opciones"
      Height          =   375
      Left            =   1320
      TabIndex        =   13
      Top             =   2640
      Width           =   975
   End
   Begin VB.Frame NumeroReg 
      Caption         =   "Registros"
      Height          =   1575
      Left            =   120
      TabIndex        =   5
      Top             =   0
      Width           =   2175
      Begin VB.CommandButton botir 
         Caption         =   ">"
         Enabled         =   0   'False
         Height          =   255
         Left            =   1560
         TabIndex        =   12
         Top             =   600
         Width           =   255
      End
      Begin VB.TextBox txtira 
         Alignment       =   2  'Center
         Height          =   255
         Left            =   840
         MaxLength       =   5
         TabIndex        =   11
         Top             =   600
         Width           =   615
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
         Left            =   840
         Locked          =   -1  'True
         TabIndex        =   9
         Top             =   1080
         Width           =   975
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
         Left            =   840
         Locked          =   -1  'True
         TabIndex        =   8
         Top             =   240
         Width           =   975
      End
      Begin VB.Label Label7 
         Caption         =   "Ir a :"
         Height          =   255
         Left            =   360
         TabIndex        =   10
         Top             =   600
         Width           =   375
      End
      Begin VB.Label Label5 
         Caption         =   "Total :"
         BeginProperty Font 
            Name            =   "MS Sans Serif"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   240
         TabIndex        =   7
         Top             =   1080
         Width           =   495
      End
      Begin VB.Label Label4 
         Caption         =   "Numero:"
         Height          =   255
         Left            =   120
         TabIndex        =   6
         Top             =   240
         Width           =   615
      End
   End
   Begin VB.CommandButton botbusca 
      Caption         =   "Buscar"
      Height          =   375
      Left            =   1320
      TabIndex        =   4
      Top             =   1680
      Width           =   975
   End
   Begin VB.CommandButton botborrar 
      Caption         =   "Eliminar"
      Height          =   375
      Left            =   1320
      TabIndex        =   3
      Top             =   2160
      Width           =   975
   End
   Begin VB.CommandButton botacerca 
      Caption         =   "Informacion"
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   2640
      Width           =   975
   End
   Begin VB.CommandButton botactualiza 
      Caption         =   "Actualizar"
      Enabled         =   0   'False
      Height          =   375
      Left            =   120
      TabIndex        =   1
      Top             =   2160
      Width           =   975
   End
   Begin VB.CommandButton botnuevo 
      Caption         =   "Nuevo"
      Height          =   375
      Left            =   120
      TabIndex        =   0
      Top             =   1680
      Width           =   975
   End
End
Attribute VB_Name = "frmFrecuencias"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Memorias(50) As Byte
Dim Valor As Boolean
Dim grabar As Boolean
Private Sub BD_Reposition()
RegTotal.Text = bd.Recordset.RecordCount
botactualiza.Enabled = False

End Sub
Private Sub botacerca_Click()
frmAbout.Visible = True
End Sub

Private Sub botactualiza_Click()
Dim Mensaje, Estilo, Título, Ayuda, Ctxt, Respuesta, MiCadena
Mensaje = "¿Desea continuar?"
Estilo = vbYesNo + vbQuestion + vbDefaultButton1
Título = "Actualizar Registro"
Respuesta = MsgBox(Mensaje, Estilo, Título, Ayuda, Ctxt)

If Respuesta = vbYes Then
    
    If txtFrecuencia.Text = "" Then
       MsgBox "Introduzca una frecuencia", vbCritical, "Frecuencia No Válida"
       grabar = False
    Else
        bd.Recordset.Edit
        bd.Recordset("Frecuencia") = txtFrecuencia.Text
        bd.Recordset.Update
        GoTo Mensaje
        Exit Sub
    End If
    
    
    If TxtMemoria.Text = "" Then TxtMemoria.Text = "0"
                        
    If IsNumeric(TxtMemoria.Text) = False Then
        MsgBox "Valor no válido", vbCritical
        grabar = False
    End If
    
    cadenamem = "Memoria=" + TxtMemoria.Text
    bd.Recordset.FindFirst cadenamem
    If bd.Recordset.NoMatch = False Then
        reg = bd.Recordset("Registro")
        MsgBox "La Memoria Esta siendo Utilizada por el registro : " + Str(reg), vbCritical
        grabar = False
        Exit Sub
    End If
    
    MEMORIA = CInt(TxtMemoria.Text)
    If MEMORIA >= 0 And MEMORIA <= 50 Then
        bd.Recordset.Edit
        bd.Recordset("Memoria") = TxtMemoria.Text
        bd.Recordset.Update
        GoTo Mensaje
        Exit Sub
    Else
        MsgBox "Solo dispone de las memorias 1 a 50 y la auxiliar 0", vbInformation
        Exit Sub
    End If
    
    bd.Recordset.Edit
    grabar = True
    
    If TxtBanda.Text = "" Then TxtBanda.Text = "2 m"
    bd.Recordset("Banda") = TxtBanda.Text
    
    If TxtLocalidad.Text = "" Then TxtLocalidad.Text = "N/A"
    bd.Recordset("Localidad") = TxtLocalidad.Text
    
    If txtfecha.Text = "" Then txtfecha.Text = Date
    bd.Recordset("Fecha") = CDate(txtfecha.Text)
    
    If TxtObserv.Text = "" Then TxtObserv.Text = "N/A"
    bd.Recordset("Observaciones") = TxtObserv.Text
    
    bd.Recordset("Comprobado") = chkcomprobado.Value
    
    If IsNumeric(txtr.Text) = True Then bd.Recordset("R") = txtr.Text
    If IsNumeric(txts.Text) = True Then bd.Recordset("S") = txts.Text
    
    If grabar = True Then
        bd.Recordset.Update
Mensaje:
        MsgBox "Frecuencia Modificada con Éxito", vbInformation
    End If
Else
grabar = False
End If
botactualiza.Enabled = False
End Sub

Private Sub botborrar_Click()
On Error Resume Next
Dim Mensaje, Estilo, Título, Ayuda, Ctxt, Respuesta, MiCadena
Mensaje = "¿Desea continuar?"
Estilo = vbYesNo + vbCritical + vbDefaultButton2
Título = "Borrar Registro"
Respuesta = MsgBox(Mensaje, Estilo, Título, Ayuda, Ctxt)

If Respuesta = vbYes Then
    bd.Recordset.Delete
    bd.Recordset.MoveFirst
    bd.Refresh
    Call frmOptions.botorden_Click
Else
actualizar = False
End If
If Err.Number = 3021 Then MsgBox "No hay ningun registro para borrar", vbInformation
End Sub

Private Sub botbusca_Click()
frmbuscar.Show (modal)
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

Private Sub botmem_Click()
frmmapamemoria.Show (modal)
End Sub

Private Sub botopciones_Click()
frmOptions.Visible = True
frmOptions.Show (modal)
End Sub

Sub botrepet_Click()

cadena = Right(txtFrecuencia.Text, 9)
cadena = Left(cadena, 8)
Modulo.grabarFrec (cadena)
frmrepetidores.Show (modal)

End Sub

Private Sub chkcomprobado_Click()
botactualiza.Enabled = True
End Sub

Private Sub chksecrafonia_Click()
    botactualiza.Enabled = True
End Sub

Sub Form_Activate()
    
    On Error Resume Next
    Call SituarBD
    bd.Refresh
    bd.Recordset.MoveLast
    bd.Recordset.MoveFirst

End Sub

Private Sub Form_GotFocus()
    Call Form_Activate
End Sub

Sub Form_Unload(Cancel As Integer)

    On Error Resume Next
    Unload frminicio
    Unload frmAbout
    Unload frmborrarbd
    Unload frmbuscar
    Unload frmnuevo
    Unload frmOptions
    Unload frmResultados
    Unload frmrepetidores
    Unload frmexportar
    Unload frmimportar
    Unload frmmapamemoria
    frmFrecuencias.Visible = False
    Unload Me
    bd.Recordset.Close
    
End Sub



Private Sub txtctcss_Click()
botactualiza.Enabled = True
End Sub

Private Sub txtdcs_Click()
botactualiza.Enabled = True
End Sub

Private Sub txtFrecuencia_Change()
    
    On Error Resume Next
    datos = bd.Recordset("Frecuencia")
    mhz = Left(datos, 3)
    khz = Right(datos, 4)
    datos = mhz + "." + khz
    txtFrecuencia.Text = datos
    
End Sub

Private Sub botnuevo_Click()
    frmnuevo.Visible = True
    frmnuevo.Show (modal)
End Sub

Private Sub txtFrecuencia_Click()
botactualiza.Enabled = True
End Sub

Private Sub txtir_Click()
botir.Enabled = True
End Sub

Private Sub txtira_Change()
botir.Enabled = True
botir.Default = True
End Sub

Private Sub TxtMemoria_click()
botactualiza.Enabled = True
End Sub

Private Sub TxtBanda_Click()
botactualiza.Enabled = True
End Sub

Private Sub TxtObserv_Click()
botactualiza.Enabled = True
End Sub

Private Sub TxtLocalidad_click()
botactualiza.Enabled = True
End Sub

Private Sub txtfecha_Click()
botactualiza.Enabled = True
End Sub

Private Sub BD_Error(DataErr As Integer, Response As Integer)
On Error Resume Next
If Err.Number = 3021 Then
    MsgBox "No hay almacenado ningun registro en la Base de Datos actualmente", vbInformation
End If

If Err.Number = 3045 Then
    MsgBox "El Gestor esta cargado y ejecutandose actualmente", vbInformation
    End
End If

If Err.Number = 3356 Then
    MsgBox "Hay alguna aplicacion usando la base de datos actualmente. Cierrela y reinicie esta aplicacion", vbInformation
    End
End If

End Sub

Sub Mostrar(Valor As Boolean)

    botnuevo.Enabled = Valor
    botbusca.Enabled = Valor
    botactualiza.Enabled = Valor
    botborrar.Enabled = Valor
    botacerca.Enabled = Valor
    botabrir.Visible = Not (Valor)
    botcerrar.Visible = Valor
    'registro.Visible = Valor
    NumeroReg.Visible = Valor
    bd.Visible = Valor
    
    If Valor = True Then
        bd.Refresh
    Else
        bd.Recordset.Close
        Unload Me
        End
    End If

End Sub

Public Sub SituarBD()
    Dim basedatos As String
        
    basedatos = App.Path + "\frecuencias.mdb"
    bd.DatabaseName = basedatos
    bd.DefaultType = 2
    bd.Connect = "Access"
    bd.RecordsetType = 1
    bd.RecordSource = "Frecuencias"
    bd.Refresh
    
    Me.bd.DatabaseName = basedatos
    frmborrarbd.bd.DatabaseName = basedatos
    frmnuevo.bd.DatabaseName = basedatos
    frmOptions.bd.DatabaseName = basedatos
    frmResultados.bd.DatabaseName = basedatos
    frmbuscar.bd.DatabaseName = basedatos
    frmrepetidores.bd.DatabaseName = basedatos
    frmexportar.bd.DatabaseName = basedatos
    frmmapamemoria.bd.DatabaseName = basedatos
    frmimportar.bd.DatabaseName = basedatos
    frmborrarbd.bd.DatabaseName = basedatos
    
End Sub

Private Sub txtr_Click()
botactualiza.Enabled = True
End Sub

Private Sub txts_Click()
botactualiza.Enabled = True
End Sub
