Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim r As MessageBoxResult
        Do
            r = MessageBox.Show("Continue?", "Question", MessageBoxButton.YesNo)
        Loop While r = MessageBoxResult.No
        Me.Close()
    End Sub
End Class
