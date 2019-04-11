<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ArtistLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim CDnumLabel As System.Windows.Forms.Label
        Me.CDcollectionDataSet = New DatabaseRelated.CDcollectionDataSet()
        Me.YAGA_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.YAGA_1TableAdapter = New DatabaseRelated.CDcollectionDataSetTableAdapters.YAGA_1TableAdapter()
        Me.TableAdapterManager = New DatabaseRelated.CDcollectionDataSetTableAdapters.TableAdapterManager()
        Me.YAGA_1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.YAGA_1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ArtistTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.CDnumTextBox = New System.Windows.Forms.TextBox()
        ArtistLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        CDnumLabel = New System.Windows.Forms.Label()
        CType(Me.CDcollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YAGA_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.YAGA_1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.YAGA_1BindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CDcollectionDataSet
        '
        Me.CDcollectionDataSet.DataSetName = "CDcollectionDataSet"
        Me.CDcollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'YAGA_1BindingSource
        '
        Me.YAGA_1BindingSource.DataMember = "YAGA 1"
        Me.YAGA_1BindingSource.DataSource = Me.CDcollectionDataSet
        '
        'YAGA_1TableAdapter
        '
        Me.YAGA_1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = DatabaseRelated.CDcollectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.YAGA_1TableAdapter = Me.YAGA_1TableAdapter
        '
        'YAGA_1BindingNavigator
        '
        Me.YAGA_1BindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.YAGA_1BindingNavigator.BindingSource = Me.YAGA_1BindingSource
        Me.YAGA_1BindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.YAGA_1BindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.YAGA_1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.YAGA_1BindingNavigatorSaveItem})
        Me.YAGA_1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.YAGA_1BindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.YAGA_1BindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.YAGA_1BindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.YAGA_1BindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.YAGA_1BindingNavigator.Name = "YAGA_1BindingNavigator"
        Me.YAGA_1BindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.YAGA_1BindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.YAGA_1BindingNavigator.TabIndex = 0
        Me.YAGA_1BindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'YAGA_1BindingNavigatorSaveItem
        '
        Me.YAGA_1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.YAGA_1BindingNavigatorSaveItem.Image = CType(resources.GetObject("YAGA_1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.YAGA_1BindingNavigatorSaveItem.Name = "YAGA_1BindingNavigatorSaveItem"
        Me.YAGA_1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.YAGA_1BindingNavigatorSaveItem.Text = "Save Data"
        '
        'ArtistLabel
        '
        ArtistLabel.AutoSize = True
        ArtistLabel.Location = New System.Drawing.Point(19, 50)
        ArtistLabel.Name = "ArtistLabel"
        ArtistLabel.Size = New System.Drawing.Size(33, 13)
        ArtistLabel.TabIndex = 1
        ArtistLabel.Text = "Artist:"
        '
        'ArtistTextBox
        '
        Me.ArtistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YAGA_1BindingSource, "Artist", True))
        Me.ArtistTextBox.Location = New System.Drawing.Point(70, 47)
        Me.ArtistTextBox.Name = "ArtistTextBox"
        Me.ArtistTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArtistTextBox.TabIndex = 2
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(19, 76)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YAGA_1BindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(70, 73)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'CDnumLabel
        '
        CDnumLabel.AutoSize = True
        CDnumLabel.Location = New System.Drawing.Point(19, 102)
        CDnumLabel.Name = "CDnumLabel"
        CDnumLabel.Size = New System.Drawing.Size(45, 13)
        CDnumLabel.TabIndex = 5
        CDnumLabel.Text = "CDnum:"
        '
        'CDnumTextBox
        '
        Me.CDnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.YAGA_1BindingSource, "CDnum", True))
        Me.CDnumTextBox.Location = New System.Drawing.Point(70, 99)
        Me.CDnumTextBox.Name = "CDnumTextBox"
        Me.CDnumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CDnumTextBox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(CDnumLabel)
        Me.Controls.Add(Me.CDnumTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(ArtistLabel)
        Me.Controls.Add(Me.ArtistTextBox)
        Me.Controls.Add(Me.YAGA_1BindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CDcollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YAGA_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.YAGA_1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.YAGA_1BindingNavigator.ResumeLayout(False)
        Me.YAGA_1BindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CDcollectionDataSet As CDcollectionDataSet
    Friend WithEvents YAGA_1BindingSource As BindingSource
    Friend WithEvents YAGA_1TableAdapter As CDcollectionDataSetTableAdapters.YAGA_1TableAdapter
    Friend WithEvents TableAdapterManager As CDcollectionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents YAGA_1BindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents YAGA_1BindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ArtistTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents CDnumTextBox As TextBox
End Class
