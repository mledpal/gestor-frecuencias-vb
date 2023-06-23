VERSION 5.00
Begin VB.Form frmResultados 
   BorderStyle     =   1  'Fixed Single
   Caption         =   "Resultados de la Busqueda"
   ClientHeight    =   3405
   ClientLeft      =   45
   ClientTop       =   330
   ClientWidth     =   10620
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3405
   ScaleWidth      =   10620
   StartUpPosition =   2  'CenterScreen
   Begin VB.Frame registro 
      Caption         =   "Registro"
      Height          =   3015
      Index           =   0
      Left            =   2640
      TabIndex        =   12
      Top             =   0
      Width           =   7935
      Begin VB.ComboBox txtCodificado 
         DataField       =   "SECRA"
         DataSource      =   "bd"
         Height          =   315
         ItemData        =   "frmResultados.frx":0000
         Left            =   5160
         List            =   "frmResultados.frx":0013
         TabIndex        =   40
         Top             =   840
         Width           =   1215
      End
      Begin VB.TextBox txts 
         Alignment       =   2  'Center
         DataField       =   "s"
         DataSource      =   "BD"
         Height          =   285
         Left            =   5160
         TabIndex        =   37
         Top             =   360
         Width           =   375
      End
      Begin VB.TextBox txtr 
         Alignment       =   2  'Center
         DataField       =   "r"
         DataSource      =   "BD"
         Height          =   285
         Left            =   5640
         TabIndex        =   36
         Top             =   360
         Width           =   375
      End
      Begin VB.ComboBox txtoffset 
         DataField       =   "offset"
         DataSource      =   "bd"
         Height          =   315
         ItemData        =   "frmResultados.frx":003A
         Left            =   6600
         List            =   "frmResultados.frx":005F
         TabIndex        =   35
         Top             =   2040
         Width           =   1215
      End
      Begin VB.CheckBox chkrepetidor 
         Caption         =   "Repetidor"
         DataField       =   "Repetidor"
         DataSource      =   "BD"
         Height          =   315
         Left            =   6600
         TabIndex        =   34
         Top             =   1680
         Width           =   1215
      End
      Begin VB.ComboBox txtmodo 
         DataField       =   "Modo"
         DataSource      =   "BD"
         Height          =   315
         ItemData        =   "frmResultados.frx":00BC
         Left            =   5400
         List            =   "frmResultados.frx":00DB
         Sorted          =   -1  'True
         TabIndex        =   33
         Top             =   2520
         Width           =   855
      End
      Begin VB.ComboBox txtdcs 
         DataField       =   "dcs"
         DataSource      =   "bd"
         Height          =   315
         ItemData        =   "frmResultados.frx":010B
         Left            =   5400
         List            =   "frmResultados.frx":024D
         TabIndex        =   23
         Top             =   2040
         Width           =   855
      End
      Begin VB.ComboBox txtctcss 
         DataField       =   "CTCSS"
         DataSource      =   "bd"
         Height          =   315
         ItemData        =   "frmResultados.frx":0465
         Left            =   5400
         List            =   "frmResultados.frx":0505
         TabIndex        =   22
         Top             =   1680
         Width           =   855
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
         TabIndex        =   21
         Top             =   840
         Width           =   1215
      End
      Begin VB.CheckBox chkcomprobado 
         Caption         =   "Comprobada"
         DataField       =   "Comprobado"
         DataSource      =   "BD"
         Height          =   375
         Left            =   6600
         TabIndex        =   20
         Top             =   120
         Width           =   1215
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
         TabIndex        =   19
         Top             =   360
         Width           =   1215
      End
      Begin VB.TextBox txtfecha 
         DataField       =   "Fecha"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   18
         Top             =   2520
         Width           =   1095
      End
      Begin VB.ComboBox TxtBanda 
         DataField       =   "Banda"
         DataSource      =   "BD"
         Height          =   315
         ItemData        =   "frmResultados.frx":0669
         Left            =   3360
         List            =   "frmResultados.frx":0688
         Sorted          =   -1  'True
         TabIndex        =   17
         Top             =   2520
         Width           =   1215
      End
      Begin VB.TextBox TxtMemoria 
         DataField       =   "Memoria"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         MaxLength       =   2
         TabIndex        =   16
         Top             =   840
         Width           =   1815
      End
      Begin VB.TextBox TxtObserv 
         DataField       =   "Observaciones"
         DataSource      =   "BD"
         Height          =   615
         Left            =   1440
         MaxLength       =   100
         MultiLine       =   -1  'True
         TabIndex        =   15
         Top             =   1320
         Width           =   3135
      End
      Begin VB.TextBox TxtLocalidad 
         DataField       =   "Localidad"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   14
         Top             =   2040
         Width           =   2415
      End
      Begin VB.TextBox txtFrecuencia 
         DataField       =   "Frecuencia"
         DataSource      =   "BD"
         Height          =   375
         Left            =   1440
         TabIndex        =   13
         Top             =   360
         Width           =   1815
      End
      Begin VB.Label Label9 
         Caption         =   "COD"
         Height          =   255
         Left            =   4680
         TabIndex        =   39
         Top             =   840
         Width           =   495
      End
      Begin VB.Label Label8 
         Caption         =   "S / R"
         Height          =   255
         Left            =   4680
         TabIndex        =   38
         Top             =   360
         Width           =   495
      End
      Begin VB.Label Label12 
         Caption         =   "Modo"
         Height          =   255
         Left            =   4680
         TabIndex        =   32
         Top             =   2520
         Width           =   615
      End
      Begin VB.Label Label11 
         Caption         =   "DCS"
         Height          =   255
         Left            =   4680
         TabIndex        =   31
         Top             =   2040
         Width           =   495
      End
      Begin VB.Label Label10 
         Caption         =   "CTCSS"
         Height          =   255
         Left            =   4680
         TabIndex        =   30
         Top             =   1680
         Width           =   615
      End
      Begin VB.Label Label6 
         Caption         =   "Fecha :"
         Height          =   255
         Left            =   720
         TabIndex        =   29
         Top             =   2520
         Width           =   615
      End
      Begin VB.Label Label1 
         Caption         =   "Banda :"
         Height          =   255
         Left            =   2760
         TabIndex        =   28
         Top             =   2520
         Width           =   615
      End
      Begin VB.Label Label3 
         Caption         =   "Localidad :"
         Height          =   255
         Left            =   600
         TabIndex        =   27
         Top             =   2040
         Width           =   855
      End
      Begin VB.Label Label2 
         Caption         =   "Observaciones :"
         Height          =   255
         Left            =   120
         TabIndex        =   26
         Top             =   1320
         Width           =   1215
      End
      Begin VB.Label Lbl2 
         Caption         =   "Memoria :"
         Height          =   255
         Left            =   600
         TabIndex        =   25
         Top             =   840
         Width           =   735
      End
      Begin VB.Label Lbl1 
         Caption         =   "Frecuencia  :"
         Height          =   255
         Left            =   360
         TabIndex        =   24
         Top             =   360
         Width           =   975
      End
   End
   Begin VB.CommandButton botfirst 
      Caption         =   "<<<"
      Enabled         =   0   'False
      Height          =   255
      Left            =   240
      TabIndex        =   11
      Top             =   2040
      Width           =   495
   End
   Begin VB.CommandButton botlast 
      Caption         =   ">>>"
      Enabled         =   0   'False
      Height          =   255
      Left            =   2040
      TabIndex        =   10
      Top             =   2040
      Width           =   495
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
      Top             =   3030
      Visible         =   0   'False
      Width           =   10620
   End
   Begin VB.TextBox txtencontrados 
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
      Left            =   1560
      Locked          =   -1  'True
      TabIndex        =   9
      Top             =   2730
      Width           =   735
   End
   Begin VB.CommandButton botactualiza 
      Caption         =   "Actualizar"
      Enabled         =   0   'False
      Height          =   375
      Left            =   240
      TabIndex        =   7
      Top             =   1080
      Width           =   2295
   End
   Begin VB.CommandButton botborrar 
      Caption         =   "Eliminar"
      Height          =   375
      Left            =   240
      TabIndex        =   6
      Top             =   1560
      Width           =   2295
   End
   Begin VB.CommandButton botnueva 
      Caption         =   "Nueva Busqueda"
      Height          =   375
      Left            =   240
      TabIndex        =   5
      Top             =   600
      Width           =   2295
   End
   Begin VB.CommandButton botinicio 
      Caption         =   "Inicio"
      Default         =   -1  'True
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   120
      Width           =   2295
   End
   Begin VB.CommandButton BotSig 
      Caption         =   ">"
      Height          =   255
      Left            =   1440
      TabIndex        =   3
      Top             =   2040
      Width           =   495
   End
   Begin VB.CommandButton botant 
      Caption         =   "<"
      Height          =   255
      Left            =   840
      TabIndex        =   2
      Top             =   2040
      Width           =   495
   End
   Begin VB.Frame frame 
      Caption         =   "   Registros Encontrados   "
      Height          =   735
      Left            =   240
      TabIndex        =   0
      Top             =   2400
      Width           =   2175
      Begin VB.TextBox NumReg 
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
         TabIndex        =   1
         Top             =   330
         Width           =   735
      End
      Begin VB.Label Label4 
         AutoSize        =   -1  'True
         Caption         =   "de"
         Height          =   195
         Left            =   960
         TabIndex        =   8
         Top             =   360
         Width           =   180
      End
   End
End
Attribute VB_Name = "frmResultados"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim Criterio As String
Dim cadenabusqueda As String

Private Sub botactualiza_Click()

cadenabusqueda = ""
Dim Mensaje, Estilo, Título, Ayuda, Ctxt, Respuesta, MiCadena
Mensaje = "¿Desea continuar?"
Estilo = vbYesNo + vbInformation + vbDefaultButton1
Título = "Actualizar Registro"
Respuesta = MsgBox(Mensaje, Estilo, Título, Ayuda, Ctxt)

If Respuesta = vbYes Then
    bd.Recordset.Edit
    
    If txtFrecuencia.Text = "" Then
       r = MsgBox("Introduzca una frecuencia", vbCritical, "ERROR GRAVE")
    Else
        Frec = txtFrecuencia.Text
        punto = InStr(Frec, ".")
        mhz = Left(Frec, (punto - 1))
        khz = Mid(Frec, (punto + 1))

        Select Case Len(mhz)
            Case 0
                mhz = "000"
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
    txtFrecuencia.Text = Frecuencia
    bd.Recordset("Frecuencia") = Frecuencia
    End If
    
    If TxtMemoria.Text = "" Then TxtMemoria.Text = ""
    bd.Recordset("Memoria") = CInt(TxtMemoria.Text)
    
    If txtfecha.Text = "" Then txtfecha.Text = Date
    bd.Recordset("Fecha") = CDate(txtfecha.Text)
       
    If TxtBanda.Text = "" Then TxtBanda.Text = "2 m"
    bd.Recordset("Banda") = TxtBanda.Text
    
    If TxtLocalidad.Text = "" Then TxtLocalidad.Text = "N/A"
    bd.Recordset("Localidad") = TxtLocalidad.Text
    
    If TxtObserv.Text = "" Then TxtObserv.Text = "N/A"
    bd.Recordset("Observaciones") = TxtObserv.Text
    
    If IsNumeric(txtr.Text) = False Then txtr.Text = "0"
    If IsNumeric(txts.Text) = False Then txts.Text = "0"
    
    bd.Recordset("R") = txtr.Text
    bd.Recordset("S") = txts.Text
    
    bd.Recordset("DCS") = txtdcs.Text
    bd.Recordset("CTCSS") = txtctcss.Text
    
    bd.Recordset("Comprobado") = chkcomprobado.Value
        
    bd.Recordset.Update
    MsgBox "Registro Actualizado con éxito", vbInformation
Else
    actualizar = False
End If
botactualiza.Enabled = False
Call frmResultados.Form_Activate
End Sub

Private Sub botant_Click()
botactualiza.Enabled = False
Criterio = leer()
bd.Recordset.FindPrevious Criterio
End Sub

Private Sub botborrar_Click()
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

    Call frmResultados.Form_Activate
Else
actualizar = False
End If
End Sub

Private Sub botfirst_Click()
Criterio = leer()
bd.Recordset.FindFirst Criterio
botactualiza.Enabled = False
End Sub

Private Sub botinicio_Click()

frmFrecuencias.txtira.Text = numreg.Text
cadenabusqueda = ""
Modulo.grabar (cadenabusqueda)
Unload frmResultados
frmFrecuencias.Visible = True


End Sub

Private Sub botlast_Click()
botactualiza.Enabled = False
Criterio = leer()
bd.Recordset.FindLast Criterio
End Sub

Private Sub botmem_Click()
frmmapamemoria.Show (modal)
End Sub

Private Sub botnueva_Click()
cadenabusqueda = ""
Modulo.grabar (cadenabusqueda)
Unload frmResultados
frmbuscar.Visible = True
frmbuscar.Show (modal)
End Sub

Private Sub botrepet_Click()

cadena = Right(txtFrecuencia.Text, 9)
cadena = Left(cadena, 8)
Modulo.grabarFrec (cadena)
frmrepetidores.Show (modal)

End Sub

Private Sub BotSig_Click()
botactualiza.Enabled = False
Criterio = leer()
bd.Recordset.FindNext Criterio
End Sub

Private Sub chkcomprobado_GotFocus()
botactualiza.Enabled = True
End Sub

Sub Form_Activate()
Call frmFrecuencias.SituarBD
bd.Refresh
Criterio = leer()
frmResultados.Caption = "Resultados de : " + Criterio
bd.Recordset.FindFirst Criterio
Registros = 0
Do
    bd.Recordset.FindNext Criterio
    Registros = Registros + 1
Loop While bd.Recordset.NoMatch = False

bd.Recordset.FindFirst Criterio
txtencontrados.Text = Registros

If CInt(Registros) > 1 Then
    botfirst.Enabled = True
    botlast.Enabled = True
End If

If CInt(Registros) = 1 Then
    BotSig.Enabled = False
    botant.Enabled = False
End If

End Sub

Private Sub txtdcs_Click()
botactualiza.Enabled = True
End Sub


Private Sub txtctcss_Click()
botactualiza.Enabled = True
End Sub

Private Sub txtFrecuencia_Click()
botactualiza.Enabled = True
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

Private Sub txtr_Click()
botactualiza.Enabled = True
End Sub

Private Sub txts_Click()
botactualiza.Enabled = True
End Sub

