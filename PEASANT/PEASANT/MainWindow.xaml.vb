Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim r As MessageBoxResult

        Do
            r = MessageBox.Show("Do you want to continue?", "Question", MessageBoxButton.YesNo)
        Loop Until r = MessageBoxResult.No

        Me.Close()

    End Sub
End Class
