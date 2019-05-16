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
        Dim CdnumLabel As System.Windows.Forms.Label
        Me.CD_CollectionDataSet = New Data_Base.CD_CollectionDataSet()
        Me.TBL_AlbumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_AlbumsTableAdapter = New Data_Base.CD_CollectionDataSetTableAdapters.TBL_AlbumsTableAdapter()
        Me.TableAdapterManager = New Data_Base.CD_CollectionDataSetTableAdapters.TableAdapterManager()
        Me.TBL_AlbumsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TBL_AlbumsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ArtistTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.CdnumTextBox = New System.Windows.Forms.TextBox()
        ArtistLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        CdnumLabel = New System.Windows.Forms.Label()
        CType(Me.CD_CollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_AlbumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBL_AlbumsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_AlbumsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CD_CollectionDataSet
        '
        Me.CD_CollectionDataSet.DataSetName = "CD_CollectionDataSet"
        Me.CD_CollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBL_AlbumsBindingSource
        '
        Me.TBL_AlbumsBindingSource.DataMember = "TBL Albums"
        Me.TBL_AlbumsBindingSource.DataSource = Me.CD_CollectionDataSet
        '
        'TBL_AlbumsTableAdapter
        '
        Me.TBL_AlbumsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.TBL_AlbumsTableAdapter = Me.TBL_AlbumsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Data_Base.CD_CollectionDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TBL_AlbumsBindingNavigator
        '
        Me.TBL_AlbumsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TBL_AlbumsBindingNavigator.BindingSource = Me.TBL_AlbumsBindingSource
        Me.TBL_AlbumsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TBL_AlbumsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TBL_AlbumsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TBL_AlbumsBindingNavigatorSaveItem})
        Me.TBL_AlbumsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TBL_AlbumsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TBL_AlbumsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TBL_AlbumsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TBL_AlbumsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TBL_AlbumsBindingNavigator.Name = "TBL_AlbumsBindingNavigator"
        Me.TBL_AlbumsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TBL_AlbumsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TBL_AlbumsBindingNavigator.TabIndex = 0
        Me.TBL_AlbumsBindingNavigator.Text = "BindingNavigator1"
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
        'TBL_AlbumsBindingNavigatorSaveItem
        '
        Me.TBL_AlbumsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TBL_AlbumsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TBL_AlbumsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TBL_AlbumsBindingNavigatorSaveItem.Name = "TBL_AlbumsBindingNavigatorSaveItem"
        Me.TBL_AlbumsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TBL_AlbumsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ArtistLabel
        '
        ArtistLabel.AutoSize = True
        ArtistLabel.Location = New System.Drawing.Point(63, 44)
        ArtistLabel.Name = "ArtistLabel"
        ArtistLabel.Size = New System.Drawing.Size(33, 13)
        ArtistLabel.TabIndex = 1
        ArtistLabel.Text = "Artist:"
        '
        'ArtistTextBox
        '
        Me.ArtistTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_AlbumsBindingSource, "Artist", True))
        Me.ArtistTextBox.Location = New System.Drawing.Point(102, 41)
        Me.ArtistTextBox.Name = "ArtistTextBox"
        Me.ArtistTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArtistTextBox.TabIndex = 2
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(106, 89)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_AlbumsBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(142, 86)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'CdnumLabel
        '
        CdnumLabel.AutoSize = True
        CdnumLabel.Location = New System.Drawing.Point(156, 144)
        CdnumLabel.Name = "CdnumLabel"
        CdnumLabel.Size = New System.Drawing.Size(43, 13)
        CdnumLabel.TabIndex = 5
        CdnumLabel.Text = "Cdnum:"
        '
        'CdnumTextBox
        '
        Me.CdnumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TBL_AlbumsBindingSource, "Cdnum", True))
        Me.CdnumTextBox.Location = New System.Drawing.Point(205, 141)
        Me.CdnumTextBox.Name = "CdnumTextBox"
        Me.CdnumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CdnumTextBox.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(CdnumLabel)
        Me.Controls.Add(Me.CdnumTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(ArtistLabel)
        Me.Controls.Add(Me.ArtistTextBox)
        Me.Controls.Add(Me.TBL_AlbumsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.CD_CollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_AlbumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBL_AlbumsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBL_AlbumsBindingNavigator.ResumeLayout(False)
        Me.TBL_AlbumsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CD_CollectionDataSet As CD_CollectionDataSet
    Friend WithEvents TBL_AlbumsBindingSource As BindingSource
    Friend WithEvents TBL_AlbumsTableAdapter As CD_CollectionDataSetTableAdapters.TBL_AlbumsTableAdapter
    Friend WithEvents TableAdapterManager As CD_CollectionDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TBL_AlbumsBindingNavigator As BindingNavigator
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
    Friend WithEvents TBL_AlbumsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ArtistTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents CdnumTextBox As TextBox
End Class
