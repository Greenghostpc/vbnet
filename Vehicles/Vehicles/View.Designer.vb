<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View
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
        Dim MakeLabel As System.Windows.Forms.Label
        Dim ModelLabel As System.Windows.Forms.Label
        Me.VehiclesDataSet = New Vehicles.VehiclesDataSet()
        Me.VehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehiclesTableAdapter = New Vehicles.VehiclesDataSetTableAdapters.VehiclesTableAdapter()
        Me.TableAdapterManager = New Vehicles.VehiclesDataSetTableAdapters.TableAdapterManager()
        Me.VehiclesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakeTextBox = New System.Windows.Forms.TextBox()
        Me.ModelTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        MakeLabel = New System.Windows.Forms.Label()
        ModelLabel = New System.Windows.Forms.Label()
        CType(Me.VehiclesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
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
        'VehiclesDataGridView
        '
        Me.VehiclesDataGridView.AutoGenerateColumns = False
        Me.VehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiclesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.VehiclesDataGridView.DataSource = Me.VehiclesBindingSource
        Me.VehiclesDataGridView.Dock = System.Windows.Forms.DockStyle.Top
        Me.VehiclesDataGridView.Location = New System.Drawing.Point(0, 24)
        Me.VehiclesDataGridView.Name = "VehiclesDataGridView"
        Me.VehiclesDataGridView.Size = New System.Drawing.Size(646, 220)
        Me.VehiclesDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Make"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Make"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ModelYear"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ModelYear"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Diesel"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Diesel"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MakeLabel
        '
        MakeLabel.AutoSize = True
        MakeLabel.Location = New System.Drawing.Point(36, 272)
        MakeLabel.Name = "MakeLabel"
        MakeLabel.Size = New System.Drawing.Size(37, 13)
        MakeLabel.TabIndex = 2
        MakeLabel.Text = "Make:"
        '
        'MakeTextBox
        '
        Me.MakeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Make", True))
        Me.MakeTextBox.Location = New System.Drawing.Point(79, 269)
        Me.MakeTextBox.Name = "MakeTextBox"
        Me.MakeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MakeTextBox.TabIndex = 3
        '
        'ModelLabel
        '
        ModelLabel.AutoSize = True
        ModelLabel.Location = New System.Drawing.Point(185, 272)
        ModelLabel.Name = "ModelLabel"
        ModelLabel.Size = New System.Drawing.Size(39, 13)
        ModelLabel.TabIndex = 4
        ModelLabel.Text = "Model:"
        '
        'ModelTextBox
        '
        Me.ModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Model", True))
        Me.ModelTextBox.Location = New System.Drawing.Point(230, 269)
        Me.ModelTextBox.Name = "ModelTextBox"
        Me.ModelTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModelTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Average Cost:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(416, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Null"
        '
        'View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 314)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(ModelLabel)
        Me.Controls.Add(Me.ModelTextBox)
        Me.Controls.Add(MakeLabel)
        Me.Controls.Add(Me.MakeTextBox)
        Me.Controls.Add(Me.VehiclesDataGridView)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "View"
        Me.Text = "View"
        CType(Me.VehiclesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VehiclesDataSet As VehiclesDataSet
    Friend WithEvents VehiclesBindingSource As BindingSource
    Friend WithEvents VehiclesTableAdapter As VehiclesDataSetTableAdapters.VehiclesTableAdapter
    Friend WithEvents TableAdapterManager As VehiclesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiclesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakeTextBox As TextBox
    Friend WithEvents ModelTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
