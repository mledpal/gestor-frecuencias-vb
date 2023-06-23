Attribute VB_Name = "Modulo"

Dim Memorias(50) As Byte
Dim archivo As String
Dim bdlocation As String
Type Registro
    Registro As Integer
    Frecuencia As String
    MEMORIA As Byte
    Observaciones As String * 100
    Localidad As String * 20
    Banda As String * 10
    Fecha As Date
    Comprobado As Boolean
    Exportar As Boolean
    mhz As String
    khz As String
    modo As String * 5
    r As Byte
    s As Byte
    secra As Boolean
    offset As Single
End Type

Public Function leer()
archivo = Environ("TEMP") + "\busca.tmp"
Open archivo For Input As #1
Input #1, leer
Close #1
End Function

Sub grabar(cadena As String)
archivo = Environ("TEMP") + "\busca.tmp"
Open archivo For Output As #1
Write #1, cadena
Close #1
End Sub
Public Function LeerFrec()
archivo = Environ("TEMP") + "\frecuencia.tmp"
Open archivo For Input As #1
Input #1, LeerFrec
Close #1
End Function

Sub grabarFrec(cadena As String)
archivo = Environ("TEMP") + "\frecuencia.tmp"
Open archivo For Output As #1
Write #1, cadena
Close #1
End Sub
Sub CopiaSeguridad()
FileCopy CStr(App.Path + "\frecuencias.mdb"), Environ("TEMP")
End Sub
