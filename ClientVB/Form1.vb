﻿Public Class Form1
    Const ITERATIONS = 500000
    Private Sub Bt_Late_Click(sender As Object, e As EventArgs) Handles Bt_Late.Click
        ' Пример позднего связывания
        Dim obj As Object
        Dim i As Long
        Dim Start As DateTime = DateTime.Now
        ' Создание объекта с указанным ProgId
        obj = CreateObject("ATL90311-2.MyMath.1")
        txtOp3.Text = obj.Add(txtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            txtOp3.Text = obj.Add(txtOp1.Text, txtOp2.Text)
        Next
        txtTime1.Text = (DateTime.Now -
Start).TotalSeconds
        obj = Nothing
    End Sub

    Private Sub Bt_ID_Click(sender As Object, e As EventArgs) Handles Bt_ID.Click
        ' Пример ID-связывания
        Dim obj As ATL903112Lib.MyMath ' указание на TypeLib
        Dim i As Long
        Dim Start As DateTime = DateTime.Now
        obj = New ATL903112Lib.MyMath
        txtOp3.Text = obj.Add(txtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            obj.Add(txtOp1.Text, txtOp2.Text)
        Next
        txtTime2.Text = (DateTime.Now -
Start).TotalSeconds
    End Sub

    Private Sub BT_vtbl_Click(sender As Object, e As EventArgs) Handles Bt_Vtbl.Click
        ' Пример связывания через vtbl(очень раннего связывания)
        Dim i As Long
        Dim obj As New ATL903112Lib.MyMath
        Dim Start As DateTime = DateTime.Now
        txtOp3.Text = obj.Add(txtOp1.Text, txtOp2.Text)
        For i = 1 To ITERATIONS
            obj.Add(txtOp1.Text, txtOp2.Text)
        Next
        txtTime3.Text = (DateTime.Now - Start).TotalSeconds
    End Sub
End Class
