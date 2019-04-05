<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updatefrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updatefrm))
        Dim IDLabel As System.Windows.Forms.Label
        Dim MakeLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Dim ModelYearLabel As System.Windows.Forms.Label
        Dim DieselLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ModelLabel1 As System.Windows.Forms.Label
        Me.VehiclesDataSet = New Vehicles.VehiclesDataSet()
        Me.VehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiclesTableAdapter = New Vehicles.VehiclesDataSetTableAdapters.VehiclesTableAdapter()
        Me.TableAdapterManager = New Vehicles.VehiclesDataSetTableAdapters.TableAdapterManager()
        Me.VehiclesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VehiclesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.MakeTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.ModelYearTextBox = New System.Windows.Forms.TextBox()
        Me.DieselCheckBox = New System.Windows.Forms.CheckBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ModelComboBox = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        IDLabel = New System.Windows.Forms.Label()
        MakeLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        ModelYearLabel = New System.Windows.Forms.Label()
        DieselLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        ModelLabel1 = New System.Windows.Forms.Label()
        CType(Me.VehiclesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehiclesBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VehiclesDataSet
        '
        Me.VehiclesDataSet.DataSetName = "VehiclesDataSet"
        Me.VehiclesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehiclesBindingSource
        '
        Me.VehiclesBindingSource.DataMember = "Vehicles"
        Me.VehiclesBindingSource.DataSource = Me.VehiclesDataSet
        '
        'VehiclesTableAdapter
        '
        Me.VehiclesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Vehicles.VehiclesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VehiclesTableAdapter = Me.VehiclesTableAdapter
        '
        'VehiclesBindingNavigator
        '
        Me.VehiclesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VehiclesBindingNavigator.BindingSource = Me.VehiclesBindingSource
        Me.VehiclesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VehiclesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VehiclesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VehiclesBindingNavigatorSaveItem})
        Me.VehiclesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VehiclesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehiclesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehiclesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehiclesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehiclesBindingNavigator.Name = "VehiclesBindingNavigator"
        Me.VehiclesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VehiclesBindingNavigator.Size = New System.Drawing.Size(375, 25)
        Me.VehiclesBindingNavigator.TabIndex = 0
        Me.VehiclesBindingNavigator.Text = "BindingNavigator1"
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
        'VehiclesBindingNavigatorSaveItem
        '
        Me.VehiclesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehiclesBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehiclesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehiclesBindingNavigatorSaveItem.Name = "VehiclesBindingNavigatorSaveItem"
        Me.VehiclesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.VehiclesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(12, 34)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(82, 31)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'MakeLabel
        '
        MakeLabel.AutoSize = True
        MakeLabel.Location = New System.Drawing.Point(12, 54)
        MakeLabel.Name = "MakeLabel"
        MakeLabel.Size = New System.Drawing.Size(37, 13)
        MakeLabel.TabIndex = 3
        MakeLabel.Text = "Make:"
        '
        'MakeTextBox
        '
        Me.MakeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Make", True))
        Me.MakeTextBox.Location = New System.Drawing.Point(82, 51)
        Me.MakeTextBox.Name = "MakeTextBox"
        Me.MakeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MakeTextBox.TabIndex = 4
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(12, 74)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 5
        ModelLabel.Text = "Model:"
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(82, 71)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 6
        '
        'ModelYearLabel
        '
        ModelYearLabel.AutoSize = True
        ModelYearLabel.Location = New System.Drawing.Point(12, 94)
        ModelYearLabel.Name = "ModelYearLabel"
        ModelYearLabel.Size = New System.Drawing.Size(64, 13)
        ModelYearLabel.TabIndex = 7
        ModelYearLabel.Text = "Model Year:"
        '
        'ModelYearTextBox
        '
        Me.ModelYearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "ModelYear", True))
        Me.ModelYearTextBox.Location = New System.Drawing.Point(82, 91)
        Me.ModelYearTextBox.Name = "ModelYearTextBox"
        Me.ModelYearTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelYearTextBox.TabIndex = 8
        '
        'DieselLabel
        '
        DieselLabel.AutoSize = True
        DieselLabel.Location = New System.Drawing.Point(12, 121)
        DieselLabel.Name = "DieselLabel"
        DieselLabel.Size = New System.Drawing.Size(39, 13)
        DieselLabel.TabIndex = 9
        DieselLabel.Text = "Diesel:"
        '
        'DieselCheckBox
        '
        Me.DieselCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VehiclesBindingSource, "Diesel", True))
        Me.DieselCheckBox.Location = New System.Drawing.Point(82, 116)
        Me.DieselCheckBox.Name = "DieselCheckBox"
        Me.DieselCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DieselCheckBox.TabIndex = 10
        Me.DieselCheckBox.Text = "Yes"
        Me.DieselCheckBox.UseVisualStyleBackColor = True
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(12, 145)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 11
        PriceLabel.Text = "Price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(82, 142)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 12
        '
        'ModelLabel1
        '
        ModelLabel1.AutoSize = True
        ModelLabel1.Location = New System.Drawing.Point(6, 16)
        ModelLabel1.Name = "ModelLabel1"
        ModelLabel1.Size = New System.Drawing.Size(39, 13)
        ModelLabel1.TabIndex = 13
        ModelLabel1.Text = "Model:"
        '
        'ModelComboBox
        '
        Me.ModelComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Model", True))
        Me.ModelComboBox.FormattingEnabled = True
        Me.ModelComboBox.Location = New System.Drawing.Point(51, 13)
        Me.ModelComboBox.Name = "ModelComboBox"
        Me.ModelComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ModelComboBox.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(ModelLabel1)
        Me.GroupBox1.Controls.Add(Me.ModelComboBox)
        Me.GroupBox1.Location = New System.Drawing.Point(188, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 45)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Find"
        '
        'Updatefrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 174)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(DieselLabel)
        Me.Controls.Add(Me.DieselCheckBox)
        Me.Controls.Add(ModelYearLabel)
        Me.Controls.Add(Me.ModelYearTextBox)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(MakeLabel)
        Me.Controls.Add(Me.MakeTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.VehiclesBindingNavigator)
        Me.Name = "Updatefrm"
        Me.Text = "Updatefrm"
        CType(Me.VehiclesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehiclesBindingNavigator.ResumeLayout(False)
        Me.VehiclesBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VehiclesDataSet As VehiclesDataSet
    Friend WithEvents VehiclesBindingSource As BindingSource
    Friend WithEvents VehiclesTableAdapter As VehiclesDataSetTableAdapters.VehiclesTableAdapter
    Friend WithEvents TableAdapterManager As VehiclesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiclesBindingNavigator As BindingNavigator
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
    Friend WithEvents VehiclesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents MakeTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents ModelYearTextBox As TextBox
    Friend WithEvents DieselCheckBox As CheckBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ModelComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
