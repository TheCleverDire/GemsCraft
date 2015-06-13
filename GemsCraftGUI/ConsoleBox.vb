' Copyright 2009-2012 Matvei Stefarov <me@matvei.org>
' Converted to VB by apotter96 for use with the GemsCraft Beta GUI
Imports System.Collections.Generic
Imports System.Windows.Forms

NotInheritable Class ConsoleBox
    Inherits TextBox
    Const WmKeydown As Integer = &H100
    Const WmSyskeydown As Integer = &H104
    Public Event OnCommand As Action
    ReadOnly _log As New List(Of String)()
    Private _logPointer As Integer

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If Not Enabled Then
            Return MyBase.ProcessCmdKey(msg, keyData)
        End If
        Select Case keyData
            Case Keys.Up
                If msg.Msg = WmSyskeydown OrElse msg.Msg = WmKeydown Then
                    If _log.Count = 0 Then
                        Return True
                    End If
                    If _logPointer = -1 Then
                        _logPointer = _log.Count - 1
                    ElseIf _logPointer > 0 Then
                        _logPointer -= 1
                    End If
                    Text = _log(_logPointer)
                    SelectAll()
                End If
                Return True

            Case Keys.Down
                If msg.Msg = WmSyskeydown OrElse msg.Msg = WmKeydown Then
                    If _log.Count = 0 OrElse _logPointer = -1 Then
                        Return True
                    End If
                    If _logPointer < _log.Count - 1 Then
                        _logPointer += 1
                    End If
                    Text = _log(_logPointer)
                    SelectAll()
                End If
                Return True

            Case Keys.Enter
                If msg.Msg = WmSyskeydown OrElse msg.Msg = WmKeydown Then
                    If Text.Trim().Length > 0 Then
                        _log.Add(Text)
                        If _log.Count > 100 Then
                            _log.RemoveAt(0)
                        End If
                        _logPointer = -1
                        RaiseEvent OnCommand()
                    End If
                End If
                Return True

            Case Keys.Escape
                If msg.Msg = WmSyskeydown OrElse msg.Msg = WmKeydown Then
                    _logPointer = _log.Count
                    Text = ""
                End If
                Return MyBase.ProcessCmdKey(msg, keyData)
            Case Else

                Return MyBase.ProcessCmdKey(msg, keyData)
        End Select
    End Function
End Class