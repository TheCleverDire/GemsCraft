<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddWorldPopup
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
        Me.gTerrainFeatures = New System.Windows.Forms.GroupBox()
        Me.lLoweredCorners = New System.Windows.Forms.Label()
        Me.nLoweredCorners = New System.Windows.Forms.NumericUpDown()
        Me.cMidpoint = New System.Windows.Forms.ComboBox()
        Me.lMidpoint = New System.Windows.Forms.Label()
        Me.lRaisedCorners = New System.Windows.Forms.Label()
        Me.nRaisedCorners = New System.Windows.Forms.NumericUpDown()
        Me.lBiasDisplay = New System.Windows.Forms.Label()
        Me.lBias = New System.Windows.Forms.Label()
        Me.sBias = New System.Windows.Forms.TrackBar()
        Me.lCaveSizeDisplay = New System.Windows.Forms.Label()
        Me.gHeightmapCreation = New System.Windows.Forms.GroupBox()
        Me.lBelowFunc = New System.Windows.Forms.Label()
        Me.lAboveFunc = New System.Windows.Forms.Label()
        Me.lBelowFuncUnits = New System.Windows.Forms.Label()
        Me.lAboveFuncUnits = New System.Windows.Forms.Label()
        Me.sAboveFunc = New System.Windows.Forms.TrackBar()
        Me.sBelowFunc = New System.Windows.Forms.TrackBar()
        Me.xDelayBias = New System.Windows.Forms.CheckBox()
        Me.xInvert = New System.Windows.Forms.CheckBox()
        Me.sDetailScale = New System.Windows.Forms.TrackBar()
        Me.lDetailSizeDisplay = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.sFeatureScale = New System.Windows.Forms.TrackBar()
        Me.lRoughnessDisplay = New System.Windows.Forms.Label()
        Me.lFeatureSizeDisplay = New System.Windows.Forms.Label()
        Me.xMatchWaterCoverage = New System.Windows.Forms.CheckBox()
        Me.sWaterCoverage = New System.Windows.Forms.TrackBar()
        Me.xLayeredHeightmap = New System.Windows.Forms.CheckBox()
        Me.xMarbledMode = New System.Windows.Forms.CheckBox()
        Me.sRoughness = New System.Windows.Forms.TrackBar()
        Me.lMatchWaterCoverageDisplay = New System.Windows.Forms.Label()
        Me.lRoughness = New System.Windows.Forms.Label()
        Me.lDetailSize = New System.Windows.Forms.Label()
        Me.xAddTrees = New System.Windows.Forms.CheckBox()
        Me.gCaves = New System.Windows.Forms.GroupBox()
        Me.lCaveDensityDisplay = New System.Windows.Forms.Label()
        Me.xCaveLava = New System.Windows.Forms.CheckBox()
        Me.xCaveWater = New System.Windows.Forms.CheckBox()
        Me.sCaveSize = New System.Windows.Forms.TrackBar()
        Me.lCaveSize = New System.Windows.Forms.Label()
        Me.sCaveDensity = New System.Windows.Forms.TrackBar()
        Me.lCaveDensity = New System.Windows.Forms.Label()
        Me.gTemplates = New System.Windows.Forms.GroupBox()
        Me.cTemplates = New System.Windows.Forms.ComboBox()
        Me.lUseTemplate = New System.Windows.Forms.Label()
        Me.bBrowseTemplate = New System.Windows.Forms.Button()
        Me.bSaveTemplate = New System.Windows.Forms.Button()
        Me.xAddCliffs = New System.Windows.Forms.CheckBox()
        Me.xAddRuins = New System.Windows.Forms.CheckBox()
        Me.xOre = New System.Windows.Forms.CheckBox()
        Me.xAddBeaches = New System.Windows.Forms.CheckBox()
        Me.gMapSize = New System.Windows.Forms.GroupBox()
        Me.nMaxDepthVariation = New System.Windows.Forms.NumericUpDown()
        Me.nMaxHeightVariation = New System.Windows.Forms.NumericUpDown()
        Me.lMaxHeightVariationUnits = New System.Windows.Forms.Label()
        Me.lMaxDepthVariationUnits = New System.Windows.Forms.Label()
        Me.xWaterLevel = New System.Windows.Forms.CheckBox()
        Me.nWaterLevel = New System.Windows.Forms.NumericUpDown()
        Me.lWaterLevelLabel = New System.Windows.Forms.Label()
        Me.nMaxDepth = New System.Windows.Forms.NumericUpDown()
        Me.nMaxHeight = New System.Windows.Forms.NumericUpDown()
        Me.nMapWidth = New System.Windows.Forms.NumericUpDown()
        Me.lMaxHeight = New System.Windows.Forms.Label()
        Me.lMaxHeightUnits = New System.Windows.Forms.Label()
        Me.lMaxDepth = New System.Windows.Forms.Label()
        Me.lMaxDepthUnits = New System.Windows.Forms.Label()
        Me.lX1 = New System.Windows.Forms.Label()
        Me.lDim = New System.Windows.Forms.Label()
        Me.lX2 = New System.Windows.Forms.Label()
        Me.nMapHeight = New System.Windows.Forms.NumericUpDown()
        Me.nMapLength = New System.Windows.Forms.NumericUpDown()
        Me.lSnowTransitionUnits = New System.Windows.Forms.Label()
        Me.lSnowAltitudeUnits = New System.Windows.Forms.Label()
        Me.gCliffs = New System.Windows.Forms.GroupBox()
        Me.xCliffSmoothing = New System.Windows.Forms.CheckBox()
        Me.lCliffThresholdUnits = New System.Windows.Forms.Label()
        Me.sCliffThreshold = New System.Windows.Forms.TrackBar()
        Me.lCliffThreshold = New System.Windows.Forms.Label()
        Me.gBeaches = New System.Windows.Forms.GroupBox()
        Me.lBeachHeight = New System.Windows.Forms.Label()
        Me.lBeachExtentUnits = New System.Windows.Forms.Label()
        Me.lBeachHeightUnits = New System.Windows.Forms.Label()
        Me.nBeachHeight = New System.Windows.Forms.NumericUpDown()
        Me.nBeachExtent = New System.Windows.Forms.NumericUpDown()
        Me.lBeachExtent = New System.Windows.Forms.Label()
        Me.lSnowTransition = New System.Windows.Forms.Label()
        Me.xSeed = New System.Windows.Forms.CheckBox()
        Me.nSeed = New System.Windows.Forms.NumericUpDown()
        Me.xAdvanced = New System.Windows.Forms.CheckBox()
        Me.lCreateMap = New System.Windows.Forms.Label()
        Me.lMapFileOptions = New System.Windows.Forms.Label()
        Me.xBlockDB = New System.Windows.Forms.CheckBox()
        Me.nSnowTransition = New System.Windows.Forms.NumericUpDown()
        Me.gTrees = New System.Windows.Forms.GroupBox()
        Me.xGiantTrees = New System.Windows.Forms.CheckBox()
        Me.lTreeHeightUnits = New System.Windows.Forms.Label()
        Me.nTreeHeightVariation = New System.Windows.Forms.NumericUpDown()
        Me.lTreeHeightVariation = New System.Windows.Forms.Label()
        Me.nTreeHeight = New System.Windows.Forms.NumericUpDown()
        Me.lTreeHeight = New System.Windows.Forms.Label()
        Me.lTreeSpacingUnits = New System.Windows.Forms.Label()
        Me.nTreeSpacingVariation = New System.Windows.Forms.NumericUpDown()
        Me.lTreeSpacingVariation = New System.Windows.Forms.Label()
        Me.nTreeSpacing = New System.Windows.Forms.NumericUpDown()
        Me.lTreeSpacing = New System.Windows.Forms.Label()
        Me.gSnow = New System.Windows.Forms.GroupBox()
        Me.nSnowAltitude = New System.Windows.Forms.NumericUpDown()
        Me.lSnowAltitude = New System.Windows.Forms.Label()
        Me.xAddSnow = New System.Windows.Forms.CheckBox()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.progressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.tStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tStatus2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tName = New System.Windows.Forms.TextBox()
        Me.lBackup = New System.Windows.Forms.Label()
        Me.lBuild = New System.Windows.Forms.Label()
        Me.bPreviewPrev = New System.Windows.Forms.Button()
        Me.previewLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.bPreviewNext = New System.Windows.Forms.Button()
        Me.lPreview = New System.Windows.Forms.Label()
        Me.xHidden = New System.Windows.Forms.CheckBox()
        Me.fileBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.lAccess = New System.Windows.Forms.Label()
        Me.lName = New System.Windows.Forms.Label()
        Me.cBuild = New System.Windows.Forms.ComboBox()
        Me.bShow = New System.Windows.Forms.Button()
        Me.xFloodBarrier = New System.Windows.Forms.CheckBox()
        Me.bGenerate = New System.Windows.Forms.Button()
        Me.lTheme = New System.Windows.Forms.Label()
        Me.cTheme = New System.Windows.Forms.ComboBox()
        Me.cWorld = New System.Windows.Forms.ComboBox()
        Me.tFile = New System.Windows.Forms.TextBox()
        Me.bBrowseFile = New System.Windows.Forms.Button()
        Me.cBackup = New System.Windows.Forms.ComboBox()
        Me.bCancel = New System.Windows.Forms.Button()
        Me.bOK = New System.Windows.Forms.Button()
        Me.cAccess = New System.Windows.Forms.ComboBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tFolder = New System.Windows.Forms.TextBox()
        Me.tabCopy = New System.Windows.Forms.TabPage()
        Me.tCopyInfo = New System.Windows.Forms.TextBox()
        Me.lWorldToCopy = New System.Windows.Forms.Label()
        Me.tabFlatgrass = New System.Windows.Forms.TabPage()
        Me.bFlatgrassGenerate = New System.Windows.Forms.Button()
        Me.nFlatgrassDimX = New System.Windows.Forms.NumericUpDown()
        Me.lFlatgrassX1 = New System.Windows.Forms.Label()
        Me.lFlatgrassDimensions = New System.Windows.Forms.Label()
        Me.lFlatgrassX2 = New System.Windows.Forms.Label()
        Me.nFlatgrassDimZ = New System.Windows.Forms.NumericUpDown()
        Me.nFlatgrassDimY = New System.Windows.Forms.NumericUpDown()
        Me.tabTerrain = New System.Windows.Forms.TabPage()
        Me.flowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.gGenOptions = New System.Windows.Forms.GroupBox()
        Me.xWater = New System.Windows.Forms.CheckBox()
        Me.xCaves = New System.Windows.Forms.CheckBox()
        Me.folderBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.lFolder = New System.Windows.Forms.Label()
        Me.bBrowseFolder = New System.Windows.Forms.Button()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabExisting = New System.Windows.Forms.TabPage()
        Me.tExistingMapInfo = New System.Windows.Forms.TextBox()
        Me.tabLoad = New System.Windows.Forms.TabPage()
        Me.lFormatList = New System.Windows.Forms.Label()
        Me.lFile = New System.Windows.Forms.Label()
        Me.tLoadFileInfo = New System.Windows.Forms.TextBox()
        Me.bSavePreview = New System.Windows.Forms.Button()
        Me.gTerrainFeatures.SuspendLayout()
        CType(Me.nLoweredCorners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nRaisedCorners, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sBias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gHeightmapCreation.SuspendLayout()
        CType(Me.sAboveFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sBelowFunc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sDetailScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sFeatureScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sWaterCoverage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sRoughness, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gCaves.SuspendLayout()
        CType(Me.sCaveSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sCaveDensity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gTemplates.SuspendLayout()
        Me.gMapSize.SuspendLayout()
        CType(Me.nMaxDepthVariation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxHeightVariation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nWaterLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMaxHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMapWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMapHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nMapLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gCliffs.SuspendLayout()
        CType(Me.sCliffThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBeaches.SuspendLayout()
        CType(Me.nBeachHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nBeachExtent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nSnowTransition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gTrees.SuspendLayout()
        CType(Me.nTreeHeightVariation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nTreeHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nTreeSpacingVariation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nTreeSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gSnow.SuspendLayout()
        CType(Me.nSnowAltitude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statusStrip.SuspendLayout()
        Me.previewLayout.SuspendLayout()
        Me.tabCopy.SuspendLayout()
        Me.tabFlatgrass.SuspendLayout()
        CType(Me.nFlatgrassDimX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nFlatgrassDimZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nFlatgrassDimY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTerrain.SuspendLayout()
        Me.flowLayoutPanel1.SuspendLayout()
        Me.gGenOptions.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.tabExisting.SuspendLayout()
        Me.tabLoad.SuspendLayout()
        Me.SuspendLayout()
        '
        'gTerrainFeatures
        '
        Me.gTerrainFeatures.Controls.Add(Me.lLoweredCorners)
        Me.gTerrainFeatures.Controls.Add(Me.nLoweredCorners)
        Me.gTerrainFeatures.Controls.Add(Me.cMidpoint)
        Me.gTerrainFeatures.Controls.Add(Me.lMidpoint)
        Me.gTerrainFeatures.Controls.Add(Me.lRaisedCorners)
        Me.gTerrainFeatures.Controls.Add(Me.nRaisedCorners)
        Me.gTerrainFeatures.Controls.Add(Me.lBiasDisplay)
        Me.gTerrainFeatures.Controls.Add(Me.lBias)
        Me.gTerrainFeatures.Controls.Add(Me.sBias)
        Me.gTerrainFeatures.Location = New System.Drawing.Point(3, 311)
        Me.gTerrainFeatures.Name = "gTerrainFeatures"
        Me.gTerrainFeatures.Size = New System.Drawing.Size(362, 84)
        Me.gTerrainFeatures.TabIndex = 10
        Me.gTerrainFeatures.TabStop = False
        Me.gTerrainFeatures.Text = "Feature Bias"
        Me.gTerrainFeatures.Visible = False
        '
        'lLoweredCorners
        '
        Me.lLoweredCorners.AutoSize = True
        Me.lLoweredCorners.Location = New System.Drawing.Point(207, 57)
        Me.lLoweredCorners.Name = "lLoweredCorners"
        Me.lLoweredCorners.Size = New System.Drawing.Size(86, 13)
        Me.lLoweredCorners.TabIndex = 66
        Me.lLoweredCorners.Text = "Lowered corners"
        '
        'nLoweredCorners
        '
        Me.nLoweredCorners.Enabled = False
        Me.nLoweredCorners.Location = New System.Drawing.Point(299, 55)
        Me.nLoweredCorners.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nLoweredCorners.Name = "nLoweredCorners"
        Me.nLoweredCorners.Size = New System.Drawing.Size(54, 20)
        Me.nLoweredCorners.TabIndex = 65
        '
        'cMidpoint
        '
        Me.cMidpoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cMidpoint.Enabled = False
        Me.cMidpoint.FormattingEnabled = True
        Me.cMidpoint.Items.AddRange(New Object() {"Lowered", "Neutral", "Raised"})
        Me.cMidpoint.Location = New System.Drawing.Point(66, 54)
        Me.cMidpoint.Name = "cMidpoint"
        Me.cMidpoint.Size = New System.Drawing.Size(101, 21)
        Me.cMidpoint.TabIndex = 1
        '
        'lMidpoint
        '
        Me.lMidpoint.AutoSize = True
        Me.lMidpoint.Location = New System.Drawing.Point(6, 57)
        Me.lMidpoint.Name = "lMidpoint"
        Me.lMidpoint.Size = New System.Drawing.Size(47, 13)
        Me.lMidpoint.TabIndex = 64
        Me.lMidpoint.Text = "Midpoint"
        '
        'lRaisedCorners
        '
        Me.lRaisedCorners.AutoSize = True
        Me.lRaisedCorners.Location = New System.Drawing.Point(215, 21)
        Me.lRaisedCorners.Name = "lRaisedCorners"
        Me.lRaisedCorners.Size = New System.Drawing.Size(78, 13)
        Me.lRaisedCorners.TabIndex = 61
        Me.lRaisedCorners.Text = "Raised corners"
        '
        'nRaisedCorners
        '
        Me.nRaisedCorners.Enabled = False
        Me.nRaisedCorners.Location = New System.Drawing.Point(299, 19)
        Me.nRaisedCorners.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nRaisedCorners.Name = "nRaisedCorners"
        Me.nRaisedCorners.Size = New System.Drawing.Size(54, 20)
        Me.nRaisedCorners.TabIndex = 2
        '
        'lBiasDisplay
        '
        Me.lBiasDisplay.AutoSize = True
        Me.lBiasDisplay.Location = New System.Drawing.Point(178, 21)
        Me.lBiasDisplay.Name = "lBiasDisplay"
        Me.lBiasDisplay.Size = New System.Drawing.Size(21, 13)
        Me.lBiasDisplay.TabIndex = 57
        Me.lBiasDisplay.Text = "0%"
        '
        'lBias
        '
        Me.lBias.AutoSize = True
        Me.lBias.Location = New System.Drawing.Point(26, 21)
        Me.lBias.Name = "lBias"
        Me.lBias.Size = New System.Drawing.Size(27, 13)
        Me.lBias.TabIndex = 50
        Me.lBias.Text = "Bias"
        '
        'sBias
        '
        Me.sBias.AutoSize = False
        Me.sBias.LargeChange = 10
        Me.sBias.Location = New System.Drawing.Point(59, 19)
        Me.sBias.Maximum = 100
        Me.sBias.Name = "sBias"
        Me.sBias.Size = New System.Drawing.Size(116, 27)
        Me.sBias.TabIndex = 0
        Me.sBias.TickFrequency = 20
        '
        'lCaveSizeDisplay
        '
        Me.lCaveSizeDisplay.AutoSize = True
        Me.lCaveSizeDisplay.Location = New System.Drawing.Point(213, 57)
        Me.lCaveSizeDisplay.Name = "lCaveSizeDisplay"
        Me.lCaveSizeDisplay.Size = New System.Drawing.Size(33, 13)
        Me.lCaveSizeDisplay.TabIndex = 68
        Me.lCaveSizeDisplay.Text = "100%"
        '
        'gHeightmapCreation
        '
        Me.gHeightmapCreation.Controls.Add(Me.lBelowFunc)
        Me.gHeightmapCreation.Controls.Add(Me.lAboveFunc)
        Me.gHeightmapCreation.Controls.Add(Me.lBelowFuncUnits)
        Me.gHeightmapCreation.Controls.Add(Me.lAboveFuncUnits)
        Me.gHeightmapCreation.Controls.Add(Me.sAboveFunc)
        Me.gHeightmapCreation.Controls.Add(Me.sBelowFunc)
        Me.gHeightmapCreation.Controls.Add(Me.xDelayBias)
        Me.gHeightmapCreation.Controls.Add(Me.xInvert)
        Me.gHeightmapCreation.Controls.Add(Me.sDetailScale)
        Me.gHeightmapCreation.Controls.Add(Me.lDetailSizeDisplay)
        Me.gHeightmapCreation.Controls.Add(Me.label5)
        Me.gHeightmapCreation.Controls.Add(Me.sFeatureScale)
        Me.gHeightmapCreation.Controls.Add(Me.lRoughnessDisplay)
        Me.gHeightmapCreation.Controls.Add(Me.lFeatureSizeDisplay)
        Me.gHeightmapCreation.Controls.Add(Me.xMatchWaterCoverage)
        Me.gHeightmapCreation.Controls.Add(Me.sWaterCoverage)
        Me.gHeightmapCreation.Controls.Add(Me.xLayeredHeightmap)
        Me.gHeightmapCreation.Controls.Add(Me.xMarbledMode)
        Me.gHeightmapCreation.Controls.Add(Me.sRoughness)
        Me.gHeightmapCreation.Controls.Add(Me.lMatchWaterCoverageDisplay)
        Me.gHeightmapCreation.Controls.Add(Me.lRoughness)
        Me.gHeightmapCreation.Controls.Add(Me.lDetailSize)
        Me.gHeightmapCreation.Location = New System.Drawing.Point(3, 401)
        Me.gHeightmapCreation.Name = "gHeightmapCreation"
        Me.gHeightmapCreation.Size = New System.Drawing.Size(362, 226)
        Me.gHeightmapCreation.TabIndex = 11
        Me.gHeightmapCreation.TabStop = False
        Me.gHeightmapCreation.Text = "Heightmap Creation"
        Me.gHeightmapCreation.Visible = False
        '
        'lBelowFunc
        '
        Me.lBelowFunc.AutoSize = True
        Me.lBelowFunc.Location = New System.Drawing.Point(26, 193)
        Me.lBelowFunc.Name = "lBelowFunc"
        Me.lBelowFunc.Size = New System.Drawing.Size(113, 13)
        Me.lBelowFunc.TabIndex = 47
        Me.lBelowFunc.Text = "Underwater steepness"
        '
        'lAboveFunc
        '
        Me.lAboveFunc.AutoSize = True
        Me.lAboveFunc.Location = New System.Drawing.Point(57, 159)
        Me.lAboveFunc.Name = "lAboveFunc"
        Me.lAboveFunc.Size = New System.Drawing.Size(82, 13)
        Me.lAboveFunc.TabIndex = 46
        Me.lAboveFunc.Text = "Land steepness"
        '
        'lBelowFuncUnits
        '
        Me.lBelowFuncUnits.AutoSize = True
        Me.lBelowFuncUnits.Location = New System.Drawing.Point(314, 193)
        Me.lBelowFuncUnits.Name = "lBelowFuncUnits"
        Me.lBelowFuncUnits.Size = New System.Drawing.Size(42, 13)
        Me.lBelowFuncUnits.TabIndex = 45
        Me.lBelowFuncUnits.Text = "100.0%"
        '
        'lAboveFuncUnits
        '
        Me.lAboveFuncUnits.AutoSize = True
        Me.lAboveFuncUnits.Location = New System.Drawing.Point(314, 159)
        Me.lAboveFuncUnits.Name = "lAboveFuncUnits"
        Me.lAboveFuncUnits.Size = New System.Drawing.Size(42, 13)
        Me.lAboveFuncUnits.TabIndex = 44
        Me.lAboveFuncUnits.Text = "100.0%"
        '
        'sAboveFunc
        '
        Me.sAboveFunc.AutoSize = False
        Me.sAboveFunc.LargeChange = 50
        Me.sAboveFunc.Location = New System.Drawing.Point(145, 157)
        Me.sAboveFunc.Maximum = 600
        Me.sAboveFunc.Name = "sAboveFunc"
        Me.sAboveFunc.Size = New System.Drawing.Size(163, 27)
        Me.sAboveFunc.SmallChange = 20
        Me.sAboveFunc.TabIndex = 43
        Me.sAboveFunc.TickFrequency = 20
        Me.sAboveFunc.Value = 300
        '
        'sBelowFunc
        '
        Me.sBelowFunc.AutoSize = False
        Me.sBelowFunc.LargeChange = 50
        Me.sBelowFunc.Location = New System.Drawing.Point(145, 190)
        Me.sBelowFunc.Maximum = 600
        Me.sBelowFunc.Name = "sBelowFunc"
        Me.sBelowFunc.Size = New System.Drawing.Size(163, 27)
        Me.sBelowFunc.SmallChange = 20
        Me.sBelowFunc.TabIndex = 42
        Me.sBelowFunc.TickFrequency = 20
        Me.sBelowFunc.Value = 300
        '
        'xDelayBias
        '
        Me.xDelayBias.AutoSize = True
        Me.xDelayBias.Location = New System.Drawing.Point(281, 87)
        Me.xDelayBias.Name = "xDelayBias"
        Me.xDelayBias.Size = New System.Drawing.Size(75, 17)
        Me.xDelayBias.TabIndex = 40
        Me.xDelayBias.Text = "Delay bias"
        Me.xDelayBias.UseVisualStyleBackColor = True
        '
        'xInvert
        '
        Me.xInvert.AutoSize = True
        Me.xInvert.Location = New System.Drawing.Point(281, 64)
        Me.xInvert.Name = "xInvert"
        Me.xInvert.Size = New System.Drawing.Size(53, 17)
        Me.xInvert.TabIndex = 39
        Me.xInvert.Text = "Invert"
        Me.xInvert.UseVisualStyleBackColor = True
        '
        'sDetailScale
        '
        Me.sDetailScale.AutoSize = False
        Me.sDetailScale.Location = New System.Drawing.Point(98, 52)
        Me.sDetailScale.Maximum = 7
        Me.sDetailScale.Minimum = -1
        Me.sDetailScale.Name = "sDetailScale"
        Me.sDetailScale.Size = New System.Drawing.Size(116, 27)
        Me.sDetailScale.TabIndex = 1
        Me.sDetailScale.Value = 7
        '
        'lDetailSizeDisplay
        '
        Me.lDetailSizeDisplay.AutoSize = True
        Me.lDetailSizeDisplay.Location = New System.Drawing.Point(216, 55)
        Me.lDetailSizeDisplay.Name = "lDetailSizeDisplay"
        Me.lDetailSizeDisplay.Size = New System.Drawing.Size(25, 13)
        Me.lDetailSizeDisplay.TabIndex = 38
        Me.lDetailSizeDisplay.Text = "1×1"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(30, 55)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(62, 13)
        Me.label5.TabIndex = 37
        Me.label5.Text = "Detail scale"
        '
        'sFeatureScale
        '
        Me.sFeatureScale.AutoSize = False
        Me.sFeatureScale.Location = New System.Drawing.Point(98, 19)
        Me.sFeatureScale.Maximum = 7
        Me.sFeatureScale.Minimum = -1
        Me.sFeatureScale.Name = "sFeatureScale"
        Me.sFeatureScale.Size = New System.Drawing.Size(116, 27)
        Me.sFeatureScale.TabIndex = 0
        Me.sFeatureScale.Value = 2
        '
        'lRoughnessDisplay
        '
        Me.lRoughnessDisplay.AutoSize = True
        Me.lRoughnessDisplay.Location = New System.Drawing.Point(216, 87)
        Me.lRoughnessDisplay.Name = "lRoughnessDisplay"
        Me.lRoughnessDisplay.Size = New System.Drawing.Size(27, 13)
        Me.lRoughnessDisplay.TabIndex = 34
        Me.lRoughnessDisplay.Text = "50%"
        '
        'lFeatureSizeDisplay
        '
        Me.lFeatureSizeDisplay.AutoSize = True
        Me.lFeatureSizeDisplay.Location = New System.Drawing.Point(215, 22)
        Me.lFeatureSizeDisplay.Name = "lFeatureSizeDisplay"
        Me.lFeatureSizeDisplay.Size = New System.Drawing.Size(25, 13)
        Me.lFeatureSizeDisplay.TabIndex = 35
        Me.lFeatureSizeDisplay.Text = "1×1"
        '
        'xMatchWaterCoverage
        '
        Me.xMatchWaterCoverage.AutoSize = True
        Me.xMatchWaterCoverage.Location = New System.Drawing.Point(6, 125)
        Me.xMatchWaterCoverage.Name = "xMatchWaterCoverage"
        Me.xMatchWaterCoverage.Size = New System.Drawing.Size(133, 17)
        Me.xMatchWaterCoverage.TabIndex = 5
        Me.xMatchWaterCoverage.Text = "Match water coverage"
        Me.xMatchWaterCoverage.UseVisualStyleBackColor = True
        '
        'sWaterCoverage
        '
        Me.sWaterCoverage.AutoSize = False
        Me.sWaterCoverage.Enabled = False
        Me.sWaterCoverage.Location = New System.Drawing.Point(145, 124)
        Me.sWaterCoverage.Maximum = 100
        Me.sWaterCoverage.Name = "sWaterCoverage"
        Me.sWaterCoverage.Size = New System.Drawing.Size(163, 27)
        Me.sWaterCoverage.TabIndex = 6
        Me.sWaterCoverage.TickFrequency = 10
        Me.sWaterCoverage.Value = 50
        '
        'xLayeredHeightmap
        '
        Me.xLayeredHeightmap.AutoSize = True
        Me.xLayeredHeightmap.Location = New System.Drawing.Point(281, 41)
        Me.xLayeredHeightmap.Name = "xLayeredHeightmap"
        Me.xLayeredHeightmap.Size = New System.Drawing.Size(48, 17)
        Me.xLayeredHeightmap.TabIndex = 3
        Me.xLayeredHeightmap.Text = "Cliffs"
        Me.xLayeredHeightmap.UseVisualStyleBackColor = True
        '
        'xMarbledMode
        '
        Me.xMarbledMode.AutoSize = True
        Me.xMarbledMode.Location = New System.Drawing.Point(281, 18)
        Me.xMarbledMode.Name = "xMarbledMode"
        Me.xMarbledMode.Size = New System.Drawing.Size(64, 17)
        Me.xMarbledMode.TabIndex = 2
        Me.xMarbledMode.Text = "Marbled"
        Me.xMarbledMode.UseVisualStyleBackColor = True
        '
        'sRoughness
        '
        Me.sRoughness.AutoSize = False
        Me.sRoughness.Location = New System.Drawing.Point(98, 85)
        Me.sRoughness.Maximum = 80
        Me.sRoughness.Minimum = 20
        Me.sRoughness.Name = "sRoughness"
        Me.sRoughness.Size = New System.Drawing.Size(116, 27)
        Me.sRoughness.TabIndex = 4
        Me.sRoughness.TickFrequency = 10
        Me.sRoughness.Value = 50
        '
        'lMatchWaterCoverageDisplay
        '
        Me.lMatchWaterCoverageDisplay.AutoSize = True
        Me.lMatchWaterCoverageDisplay.Location = New System.Drawing.Point(314, 129)
        Me.lMatchWaterCoverageDisplay.Name = "lMatchWaterCoverageDisplay"
        Me.lMatchWaterCoverageDisplay.Size = New System.Drawing.Size(27, 13)
        Me.lMatchWaterCoverageDisplay.TabIndex = 33
        Me.lMatchWaterCoverageDisplay.Text = "50%"
        '
        'lRoughness
        '
        Me.lRoughness.AutoSize = True
        Me.lRoughness.Location = New System.Drawing.Point(31, 87)
        Me.lRoughness.Name = "lRoughness"
        Me.lRoughness.Size = New System.Drawing.Size(61, 13)
        Me.lRoughness.TabIndex = 25
        Me.lRoughness.Text = "Roughness"
        '
        'lDetailSize
        '
        Me.lDetailSize.AutoSize = True
        Me.lDetailSize.Location = New System.Drawing.Point(21, 22)
        Me.lDetailSize.Name = "lDetailSize"
        Me.lDetailSize.Size = New System.Drawing.Size(71, 13)
        Me.lDetailSize.TabIndex = 23
        Me.lDetailSize.Text = "Feature scale"
        '
        'xAddTrees
        '
        Me.xAddTrees.AutoSize = True
        Me.xAddTrees.Checked = True
        Me.xAddTrees.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xAddTrees.Location = New System.Drawing.Point(13, 19)
        Me.xAddTrees.Name = "xAddTrees"
        Me.xAddTrees.Size = New System.Drawing.Size(53, 17)
        Me.xAddTrees.TabIndex = 5
        Me.xAddTrees.Text = "Trees"
        Me.xAddTrees.UseVisualStyleBackColor = True
        '
        'gCaves
        '
        Me.gCaves.Controls.Add(Me.lCaveSizeDisplay)
        Me.gCaves.Controls.Add(Me.lCaveDensityDisplay)
        Me.gCaves.Controls.Add(Me.xCaveLava)
        Me.gCaves.Controls.Add(Me.xCaveWater)
        Me.gCaves.Controls.Add(Me.sCaveSize)
        Me.gCaves.Controls.Add(Me.lCaveSize)
        Me.gCaves.Controls.Add(Me.sCaveDensity)
        Me.gCaves.Controls.Add(Me.lCaveDensity)
        Me.gCaves.Location = New System.Drawing.Point(3, 633)
        Me.gCaves.Name = "gCaves"
        Me.gCaves.Size = New System.Drawing.Size(362, 91)
        Me.gCaves.TabIndex = 22
        Me.gCaves.TabStop = False
        Me.gCaves.Text = "Caves"
        Me.gCaves.Visible = False
        '
        'lCaveDensityDisplay
        '
        Me.lCaveDensityDisplay.AutoSize = True
        Me.lCaveDensityDisplay.Location = New System.Drawing.Point(213, 23)
        Me.lCaveDensityDisplay.Name = "lCaveDensityDisplay"
        Me.lCaveDensityDisplay.Size = New System.Drawing.Size(33, 13)
        Me.lCaveDensityDisplay.TabIndex = 67
        Me.lCaveDensityDisplay.Text = "200%"
        '
        'xCaveLava
        '
        Me.xCaveLava.AutoSize = True
        Me.xCaveLava.Location = New System.Drawing.Point(260, 56)
        Me.xCaveLava.Name = "xCaveLava"
        Me.xCaveLava.Size = New System.Drawing.Size(82, 17)
        Me.xCaveLava.TabIndex = 65
        Me.xCaveLava.Text = "Lava caves"
        Me.xCaveLava.UseVisualStyleBackColor = True
        '
        'xCaveWater
        '
        Me.xCaveWater.AutoSize = True
        Me.xCaveWater.Location = New System.Drawing.Point(260, 22)
        Me.xCaveWater.Name = "xCaveWater"
        Me.xCaveWater.Size = New System.Drawing.Size(96, 17)
        Me.xCaveWater.TabIndex = 64
        Me.xCaveWater.Text = "Flooded caves"
        Me.xCaveWater.UseVisualStyleBackColor = True
        '
        'sCaveSize
        '
        Me.sCaveSize.AutoSize = False
        Me.sCaveSize.LargeChange = 25
        Me.sCaveSize.Location = New System.Drawing.Point(98, 55)
        Me.sCaveSize.Maximum = 250
        Me.sCaveSize.Minimum = 50
        Me.sCaveSize.Name = "sCaveSize"
        Me.sCaveSize.Size = New System.Drawing.Size(116, 27)
        Me.sCaveSize.TabIndex = 63
        Me.sCaveSize.TickFrequency = 50
        Me.sCaveSize.Value = 100
        '
        'lCaveSize
        '
        Me.lCaveSize.AutoSize = True
        Me.lCaveSize.Location = New System.Drawing.Point(39, 57)
        Me.lCaveSize.Name = "lCaveSize"
        Me.lCaveSize.Size = New System.Drawing.Size(53, 13)
        Me.lCaveSize.TabIndex = 62
        Me.lCaveSize.Text = "Cave size"
        '
        'sCaveDensity
        '
        Me.sCaveDensity.AutoSize = False
        Me.sCaveDensity.LargeChange = 25
        Me.sCaveDensity.Location = New System.Drawing.Point(98, 22)
        Me.sCaveDensity.Maximum = 500
        Me.sCaveDensity.Minimum = 50
        Me.sCaveDensity.Name = "sCaveDensity"
        Me.sCaveDensity.Size = New System.Drawing.Size(116, 27)
        Me.sCaveDensity.TabIndex = 61
        Me.sCaveDensity.TickFrequency = 50
        Me.sCaveDensity.Value = 200
        '
        'lCaveDensity
        '
        Me.lCaveDensity.AutoSize = True
        Me.lCaveDensity.Location = New System.Drawing.Point(24, 23)
        Me.lCaveDensity.Name = "lCaveDensity"
        Me.lCaveDensity.Size = New System.Drawing.Size(68, 13)
        Me.lCaveDensity.TabIndex = 60
        Me.lCaveDensity.Text = "Cave density"
        '
        'gTemplates
        '
        Me.gTemplates.Controls.Add(Me.cTemplates)
        Me.gTemplates.Controls.Add(Me.lUseTemplate)
        Me.gTemplates.Controls.Add(Me.bBrowseTemplate)
        Me.gTemplates.Controls.Add(Me.bSaveTemplate)
        Me.gTemplates.Location = New System.Drawing.Point(3, 100)
        Me.gTemplates.Name = "gTemplates"
        Me.gTemplates.Size = New System.Drawing.Size(362, 52)
        Me.gTemplates.TabIndex = 21
        Me.gTemplates.TabStop = False
        Me.gTemplates.Text = "Templates"
        '
        'cTemplates
        '
        Me.cTemplates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTemplates.FormattingEnabled = True
        Me.cTemplates.Location = New System.Drawing.Point(98, 21)
        Me.cTemplates.Name = "cTemplates"
        Me.cTemplates.Size = New System.Drawing.Size(116, 21)
        Me.cTemplates.TabIndex = 4
        '
        'lUseTemplate
        '
        Me.lUseTemplate.AutoSize = True
        Me.lUseTemplate.Location = New System.Drawing.Point(23, 24)
        Me.lUseTemplate.Name = "lUseTemplate"
        Me.lUseTemplate.Size = New System.Drawing.Size(69, 13)
        Me.lUseTemplate.TabIndex = 3
        Me.lUseTemplate.Text = "Use template"
        '
        'bBrowseTemplate
        '
        Me.bBrowseTemplate.Location = New System.Drawing.Point(222, 19)
        Me.bBrowseTemplate.Name = "bBrowseTemplate"
        Me.bBrowseTemplate.Size = New System.Drawing.Size(64, 23)
        Me.bBrowseTemplate.TabIndex = 1
        Me.bBrowseTemplate.Text = "Browse"
        Me.bBrowseTemplate.UseVisualStyleBackColor = True
        '
        'bSaveTemplate
        '
        Me.bSaveTemplate.Location = New System.Drawing.Point(292, 19)
        Me.bSaveTemplate.Name = "bSaveTemplate"
        Me.bSaveTemplate.Size = New System.Drawing.Size(64, 23)
        Me.bSaveTemplate.TabIndex = 0
        Me.bSaveTemplate.Text = "Save"
        Me.bSaveTemplate.UseVisualStyleBackColor = True
        '
        'xAddCliffs
        '
        Me.xAddCliffs.AutoSize = True
        Me.xAddCliffs.Location = New System.Drawing.Point(254, 42)
        Me.xAddCliffs.Name = "xAddCliffs"
        Me.xAddCliffs.Size = New System.Drawing.Size(48, 17)
        Me.xAddCliffs.TabIndex = 69
        Me.xAddCliffs.Text = "Cliffs"
        Me.xAddCliffs.UseVisualStyleBackColor = True
        '
        'xAddRuins
        '
        Me.xAddRuins.AutoSize = True
        Me.xAddRuins.Enabled = False
        Me.xAddRuins.Location = New System.Drawing.Point(254, 19)
        Me.xAddRuins.Name = "xAddRuins"
        Me.xAddRuins.Size = New System.Drawing.Size(53, 17)
        Me.xAddRuins.TabIndex = 68
        Me.xAddRuins.Text = "Ruins"
        Me.xAddRuins.UseVisualStyleBackColor = True
        '
        'xOre
        '
        Me.xOre.AutoSize = True
        Me.xOre.Location = New System.Drawing.Point(110, 65)
        Me.xOre.Name = "xOre"
        Me.xOre.Size = New System.Drawing.Size(71, 17)
        Me.xOre.TabIndex = 67
        Me.xOre.Text = "Ore veins"
        Me.xOre.UseVisualStyleBackColor = True
        '
        'xAddBeaches
        '
        Me.xAddBeaches.AutoSize = True
        Me.xAddBeaches.Location = New System.Drawing.Point(110, 19)
        Me.xAddBeaches.Name = "xAddBeaches"
        Me.xAddBeaches.Size = New System.Drawing.Size(68, 17)
        Me.xAddBeaches.TabIndex = 58
        Me.xAddBeaches.Text = "Beaches"
        Me.xAddBeaches.UseVisualStyleBackColor = True
        '
        'gMapSize
        '
        Me.gMapSize.Controls.Add(Me.nMaxDepthVariation)
        Me.gMapSize.Controls.Add(Me.nMaxHeightVariation)
        Me.gMapSize.Controls.Add(Me.lMaxHeightVariationUnits)
        Me.gMapSize.Controls.Add(Me.lMaxDepthVariationUnits)
        Me.gMapSize.Controls.Add(Me.xWaterLevel)
        Me.gMapSize.Controls.Add(Me.nWaterLevel)
        Me.gMapSize.Controls.Add(Me.lWaterLevelLabel)
        Me.gMapSize.Controls.Add(Me.nMaxDepth)
        Me.gMapSize.Controls.Add(Me.nMaxHeight)
        Me.gMapSize.Controls.Add(Me.nMapWidth)
        Me.gMapSize.Controls.Add(Me.lMaxHeight)
        Me.gMapSize.Controls.Add(Me.lMaxHeightUnits)
        Me.gMapSize.Controls.Add(Me.lMaxDepth)
        Me.gMapSize.Controls.Add(Me.lMaxDepthUnits)
        Me.gMapSize.Controls.Add(Me.lX1)
        Me.gMapSize.Controls.Add(Me.lDim)
        Me.gMapSize.Controls.Add(Me.lX2)
        Me.gMapSize.Controls.Add(Me.nMapHeight)
        Me.gMapSize.Controls.Add(Me.nMapLength)
        Me.gMapSize.Location = New System.Drawing.Point(3, 158)
        Me.gMapSize.Name = "gMapSize"
        Me.gMapSize.Size = New System.Drawing.Size(362, 147)
        Me.gMapSize.TabIndex = 9
        Me.gMapSize.TabStop = False
        Me.gMapSize.Text = "Dimensions"
        '
        'nMaxDepthVariation
        '
        Me.nMaxDepthVariation.Location = New System.Drawing.Point(167, 78)
        Me.nMaxDepthVariation.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMaxDepthVariation.Name = "nMaxDepthVariation"
        Me.nMaxDepthVariation.Size = New System.Drawing.Size(54, 20)
        Me.nMaxDepthVariation.TabIndex = 50
        '
        'nMaxHeightVariation
        '
        Me.nMaxHeightVariation.Location = New System.Drawing.Point(167, 52)
        Me.nMaxHeightVariation.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMaxHeightVariation.Name = "nMaxHeightVariation"
        Me.nMaxHeightVariation.Size = New System.Drawing.Size(54, 20)
        Me.nMaxHeightVariation.TabIndex = 49
        Me.nMaxHeightVariation.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lMaxHeightVariationUnits
        '
        Me.lMaxHeightVariationUnits.AutoSize = True
        Me.lMaxHeightVariationUnits.Location = New System.Drawing.Point(227, 54)
        Me.lMaxHeightVariationUnits.Name = "lMaxHeightVariationUnits"
        Me.lMaxHeightVariationUnits.Size = New System.Drawing.Size(38, 13)
        Me.lMaxHeightVariationUnits.TabIndex = 51
        Me.lMaxHeightVariationUnits.Text = "blocks"
        '
        'lMaxDepthVariationUnits
        '
        Me.lMaxDepthVariationUnits.AutoSize = True
        Me.lMaxDepthVariationUnits.Location = New System.Drawing.Point(227, 80)
        Me.lMaxDepthVariationUnits.Name = "lMaxDepthVariationUnits"
        Me.lMaxDepthVariationUnits.Size = New System.Drawing.Size(38, 13)
        Me.lMaxDepthVariationUnits.TabIndex = 52
        Me.lMaxDepthVariationUnits.Text = "blocks"
        '
        'xWaterLevel
        '
        Me.xWaterLevel.AutoSize = True
        Me.xWaterLevel.Location = New System.Drawing.Point(31, 122)
        Me.xWaterLevel.Name = "xWaterLevel"
        Me.xWaterLevel.Size = New System.Drawing.Size(115, 17)
        Me.xWaterLevel.TabIndex = 48
        Me.xWaterLevel.Text = "Custom water level"
        Me.xWaterLevel.UseVisualStyleBackColor = True
        '
        'nWaterLevel
        '
        Me.nWaterLevel.Location = New System.Drawing.Point(152, 121)
        Me.nWaterLevel.Name = "nWaterLevel"
        Me.nWaterLevel.Size = New System.Drawing.Size(54, 20)
        Me.nWaterLevel.TabIndex = 45
        Me.nWaterLevel.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lWaterLevelLabel
        '
        Me.lWaterLevelLabel.AutoSize = True
        Me.lWaterLevelLabel.Location = New System.Drawing.Point(212, 123)
        Me.lWaterLevelLabel.Name = "lWaterLevelLabel"
        Me.lWaterLevelLabel.Size = New System.Drawing.Size(38, 13)
        Me.lWaterLevelLabel.TabIndex = 47
        Me.lWaterLevelLabel.Text = "blocks"
        '
        'nMaxDepth
        '
        Me.nMaxDepth.Location = New System.Drawing.Point(80, 78)
        Me.nMaxDepth.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMaxDepth.Name = "nMaxDepth"
        Me.nMaxDepth.Size = New System.Drawing.Size(54, 20)
        Me.nMaxDepth.TabIndex = 4
        Me.nMaxDepth.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'nMaxHeight
        '
        Me.nMaxHeight.Location = New System.Drawing.Point(80, 52)
        Me.nMaxHeight.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMaxHeight.Name = "nMaxHeight"
        Me.nMaxHeight.Size = New System.Drawing.Size(54, 20)
        Me.nMaxHeight.TabIndex = 3
        Me.nMaxHeight.Value = New Decimal(New Integer() {22, 0, 0, 0})
        '
        'nMapWidth
        '
        Me.nMapWidth.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nMapWidth.Location = New System.Drawing.Point(80, 19)
        Me.nMapWidth.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMapWidth.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nMapWidth.Name = "nMapWidth"
        Me.nMapWidth.Size = New System.Drawing.Size(54, 20)
        Me.nMapWidth.TabIndex = 0
        Me.nMapWidth.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'lMaxHeight
        '
        Me.lMaxHeight.AutoSize = True
        Me.lMaxHeight.Location = New System.Drawing.Point(10, 54)
        Me.lMaxHeight.Name = "lMaxHeight"
        Me.lMaxHeight.Size = New System.Drawing.Size(64, 13)
        Me.lMaxHeight.TabIndex = 40
        Me.lMaxHeight.Text = "Peak height"
        '
        'lMaxHeightUnits
        '
        Me.lMaxHeightUnits.AutoSize = True
        Me.lMaxHeightUnits.Location = New System.Drawing.Point(140, 54)
        Me.lMaxHeightUnits.Name = "lMaxHeightUnits"
        Me.lMaxHeightUnits.Size = New System.Drawing.Size(21, 13)
        Me.lMaxHeightUnits.TabIndex = 41
        Me.lMaxHeightUnits.Text = "+/-"
        '
        'lMaxDepth
        '
        Me.lMaxDepth.AutoSize = True
        Me.lMaxDepth.Location = New System.Drawing.Point(17, 80)
        Me.lMaxDepth.Name = "lMaxDepth"
        Me.lMaxDepth.Size = New System.Drawing.Size(57, 13)
        Me.lMaxDepth.TabIndex = 42
        Me.lMaxDepth.Text = "Max depth"
        '
        'lMaxDepthUnits
        '
        Me.lMaxDepthUnits.AutoSize = True
        Me.lMaxDepthUnits.Location = New System.Drawing.Point(140, 80)
        Me.lMaxDepthUnits.Name = "lMaxDepthUnits"
        Me.lMaxDepthUnits.Size = New System.Drawing.Size(21, 13)
        Me.lMaxDepthUnits.TabIndex = 44
        Me.lMaxDepthUnits.Text = "+/-"
        '
        'lX1
        '
        Me.lX1.AutoSize = True
        Me.lX1.Location = New System.Drawing.Point(140, 21)
        Me.lX1.Name = "lX1"
        Me.lX1.Size = New System.Drawing.Size(13, 13)
        Me.lX1.TabIndex = 5
        Me.lX1.Text = "×"
        '
        'lDim
        '
        Me.lDim.AutoSize = True
        Me.lDim.Location = New System.Drawing.Point(13, 21)
        Me.lDim.Name = "lDim"
        Me.lDim.Size = New System.Drawing.Size(61, 13)
        Me.lDim.TabIndex = 3
        Me.lDim.Text = "Dimensions"
        '
        'lX2
        '
        Me.lX2.AutoSize = True
        Me.lX2.Location = New System.Drawing.Point(219, 21)
        Me.lX2.Name = "lX2"
        Me.lX2.Size = New System.Drawing.Size(13, 13)
        Me.lX2.TabIndex = 6
        Me.lX2.Text = "×"
        '
        'nMapHeight
        '
        Me.nMapHeight.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nMapHeight.Location = New System.Drawing.Point(238, 19)
        Me.nMapHeight.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMapHeight.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nMapHeight.Name = "nMapHeight"
        Me.nMapHeight.Size = New System.Drawing.Size(54, 20)
        Me.nMapHeight.TabIndex = 2
        Me.nMapHeight.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'nMapLength
        '
        Me.nMapLength.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nMapLength.Location = New System.Drawing.Point(159, 19)
        Me.nMapLength.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nMapLength.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nMapLength.Name = "nMapLength"
        Me.nMapLength.Size = New System.Drawing.Size(54, 20)
        Me.nMapLength.TabIndex = 1
        Me.nMapLength.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'lSnowTransitionUnits
        '
        Me.lSnowTransitionUnits.AutoSize = True
        Me.lSnowTransitionUnits.Location = New System.Drawing.Point(318, 21)
        Me.lSnowTransitionUnits.Name = "lSnowTransitionUnits"
        Me.lSnowTransitionUnits.Size = New System.Drawing.Size(38, 13)
        Me.lSnowTransitionUnits.TabIndex = 69
        Me.lSnowTransitionUnits.Text = "blocks"
        '
        'lSnowAltitudeUnits
        '
        Me.lSnowAltitudeUnits.AutoSize = True
        Me.lSnowAltitudeUnits.Location = New System.Drawing.Point(143, 21)
        Me.lSnowAltitudeUnits.Name = "lSnowAltitudeUnits"
        Me.lSnowAltitudeUnits.Size = New System.Drawing.Size(38, 13)
        Me.lSnowAltitudeUnits.TabIndex = 67
        Me.lSnowAltitudeUnits.Text = "blocks"
        '
        'gCliffs
        '
        Me.gCliffs.Controls.Add(Me.xCliffSmoothing)
        Me.gCliffs.Controls.Add(Me.lCliffThresholdUnits)
        Me.gCliffs.Controls.Add(Me.sCliffThreshold)
        Me.gCliffs.Controls.Add(Me.lCliffThreshold)
        Me.gCliffs.Location = New System.Drawing.Point(3, 862)
        Me.gCliffs.Name = "gCliffs"
        Me.gCliffs.Size = New System.Drawing.Size(362, 59)
        Me.gCliffs.TabIndex = 23
        Me.gCliffs.TabStop = False
        Me.gCliffs.Text = "Cliffs"
        Me.gCliffs.Visible = False
        '
        'xCliffSmoothing
        '
        Me.xCliffSmoothing.AutoSize = True
        Me.xCliffSmoothing.Location = New System.Drawing.Point(260, 23)
        Me.xCliffSmoothing.Name = "xCliffSmoothing"
        Me.xCliffSmoothing.Size = New System.Drawing.Size(74, 17)
        Me.xCliffSmoothing.TabIndex = 75
        Me.xCliffSmoothing.Text = "Smoothed"
        Me.xCliffSmoothing.UseVisualStyleBackColor = True
        '
        'lCliffThresholdUnits
        '
        Me.lCliffThresholdUnits.AutoSize = True
        Me.lCliffThresholdUnits.Location = New System.Drawing.Point(213, 23)
        Me.lCliffThresholdUnits.Name = "lCliffThresholdUnits"
        Me.lCliffThresholdUnits.Size = New System.Drawing.Size(33, 13)
        Me.lCliffThresholdUnits.TabIndex = 74
        Me.lCliffThresholdUnits.Text = "100%"
        '
        'sCliffThreshold
        '
        Me.sCliffThreshold.AutoSize = False
        Me.sCliffThreshold.LargeChange = 20
        Me.sCliffThreshold.Location = New System.Drawing.Point(103, 19)
        Me.sCliffThreshold.Maximum = 200
        Me.sCliffThreshold.Minimum = 20
        Me.sCliffThreshold.Name = "sCliffThreshold"
        Me.sCliffThreshold.Size = New System.Drawing.Size(110, 27)
        Me.sCliffThreshold.TabIndex = 73
        Me.sCliffThreshold.TickFrequency = 10
        Me.sCliffThreshold.Value = 100
        '
        'lCliffThreshold
        '
        Me.lCliffThreshold.AutoSize = True
        Me.lCliffThreshold.Location = New System.Drawing.Point(43, 24)
        Me.lCliffThreshold.Name = "lCliffThreshold"
        Me.lCliffThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lCliffThreshold.TabIndex = 72
        Me.lCliffThreshold.Text = "Threshold"
        '
        'gBeaches
        '
        Me.gBeaches.Controls.Add(Me.lBeachHeight)
        Me.gBeaches.Controls.Add(Me.lBeachExtentUnits)
        Me.gBeaches.Controls.Add(Me.lBeachHeightUnits)
        Me.gBeaches.Controls.Add(Me.nBeachHeight)
        Me.gBeaches.Controls.Add(Me.nBeachExtent)
        Me.gBeaches.Controls.Add(Me.lBeachExtent)
        Me.gBeaches.Location = New System.Drawing.Point(3, 927)
        Me.gBeaches.Name = "gBeaches"
        Me.gBeaches.Size = New System.Drawing.Size(362, 48)
        Me.gBeaches.TabIndex = 76
        Me.gBeaches.TabStop = False
        Me.gBeaches.Text = "Beaches"
        Me.gBeaches.Visible = False
        '
        'lBeachHeight
        '
        Me.lBeachHeight.AutoSize = True
        Me.lBeachHeight.Location = New System.Drawing.Point(216, 23)
        Me.lBeachHeight.Name = "lBeachHeight"
        Me.lBeachHeight.Size = New System.Drawing.Size(38, 13)
        Me.lBeachHeight.TabIndex = 69
        Me.lBeachHeight.Text = "Height"
        '
        'lBeachExtentUnits
        '
        Me.lBeachExtentUnits.AutoSize = True
        Me.lBeachExtentUnits.Location = New System.Drawing.Point(143, 23)
        Me.lBeachExtentUnits.Name = "lBeachExtentUnits"
        Me.lBeachExtentUnits.Size = New System.Drawing.Size(38, 13)
        Me.lBeachExtentUnits.TabIndex = 68
        Me.lBeachExtentUnits.Text = "blocks"
        '
        'lBeachHeightUnits
        '
        Me.lBeachHeightUnits.AutoSize = True
        Me.lBeachHeightUnits.Location = New System.Drawing.Point(320, 23)
        Me.lBeachHeightUnits.Name = "lBeachHeightUnits"
        Me.lBeachHeightUnits.Size = New System.Drawing.Size(38, 13)
        Me.lBeachHeightUnits.TabIndex = 67
        Me.lBeachHeightUnits.Text = "blocks"
        '
        'nBeachHeight
        '
        Me.nBeachHeight.Location = New System.Drawing.Point(260, 21)
        Me.nBeachHeight.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.nBeachHeight.Name = "nBeachHeight"
        Me.nBeachHeight.Size = New System.Drawing.Size(54, 20)
        Me.nBeachHeight.TabIndex = 64
        Me.nBeachHeight.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'nBeachExtent
        '
        Me.nBeachExtent.Location = New System.Drawing.Point(83, 19)
        Me.nBeachExtent.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nBeachExtent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nBeachExtent.Name = "nBeachExtent"
        Me.nBeachExtent.Size = New System.Drawing.Size(54, 20)
        Me.nBeachExtent.TabIndex = 63
        Me.nBeachExtent.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'lBeachExtent
        '
        Me.lBeachExtent.AutoSize = True
        Me.lBeachExtent.Location = New System.Drawing.Point(40, 23)
        Me.lBeachExtent.Name = "lBeachExtent"
        Me.lBeachExtent.Size = New System.Drawing.Size(37, 13)
        Me.lBeachExtent.TabIndex = 65
        Me.lBeachExtent.Text = "Extent"
        '
        'lSnowTransition
        '
        Me.lSnowTransition.AutoSize = True
        Me.lSnowTransition.Location = New System.Drawing.Point(217, 21)
        Me.lSnowTransition.Name = "lSnowTransition"
        Me.lSnowTransition.Size = New System.Drawing.Size(35, 13)
        Me.lSnowTransition.TabIndex = 68
        Me.lSnowTransition.Text = "Dither"
        '
        'xSeed
        '
        Me.xSeed.AutoSize = True
        Me.xSeed.Location = New System.Drawing.Point(224, 34)
        Me.xSeed.Name = "xSeed"
        Me.xSeed.Size = New System.Drawing.Size(51, 17)
        Me.xSeed.TabIndex = 6
        Me.xSeed.Text = "Seed"
        Me.xSeed.UseVisualStyleBackColor = True
        '
        'nSeed
        '
        Me.nSeed.Enabled = False
        Me.nSeed.Location = New System.Drawing.Point(281, 33)
        Me.nSeed.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nSeed.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.nSeed.Name = "nSeed"
        Me.nSeed.Size = New System.Drawing.Size(87, 20)
        Me.nSeed.TabIndex = 7
        '
        'xAdvanced
        '
        Me.xAdvanced.AutoSize = True
        Me.xAdvanced.Location = New System.Drawing.Point(107, 22)
        Me.xAdvanced.Name = "xAdvanced"
        Me.xAdvanced.Size = New System.Drawing.Size(75, 17)
        Me.xAdvanced.TabIndex = 1
        Me.xAdvanced.Text = "Advanced"
        Me.xAdvanced.UseVisualStyleBackColor = True
        '
        'lCreateMap
        '
        Me.lCreateMap.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lCreateMap.AutoSize = True
        Me.lCreateMap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCreateMap.ForeColor = System.Drawing.Color.Red
        Me.lCreateMap.Location = New System.Drawing.Point(610, 533)
        Me.lCreateMap.Name = "lCreateMap"
        Me.lCreateMap.Size = New System.Drawing.Size(150, 13)
        Me.lCreateMap.TabIndex = 33
        Me.lCreateMap.Text = "Create a map to continue"
        '
        'lMapFileOptions
        '
        Me.lMapFileOptions.AutoSize = True
        Me.lMapFileOptions.Location = New System.Drawing.Point(12, 88)
        Me.lMapFileOptions.Name = "lMapFileOptions"
        Me.lMapFileOptions.Size = New System.Drawing.Size(47, 13)
        Me.lMapFileOptions.TabIndex = 28
        Me.lMapFileOptions.Text = "Map file:"
        '
        'xBlockDB
        '
        Me.xBlockDB.AutoSize = True
        Me.xBlockDB.Location = New System.Drawing.Point(246, 61)
        Me.xBlockDB.Name = "xBlockDB"
        Me.xBlockDB.Size = New System.Drawing.Size(68, 17)
        Me.xBlockDB.TabIndex = 27
        Me.xBlockDB.Text = "BlockDB"
        Me.xBlockDB.ThreeState = True
        Me.xBlockDB.UseVisualStyleBackColor = True
        '
        'nSnowTransition
        '
        Me.nSnowTransition.Location = New System.Drawing.Point(258, 19)
        Me.nSnowTransition.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nSnowTransition.Name = "nSnowTransition"
        Me.nSnowTransition.Size = New System.Drawing.Size(54, 20)
        Me.nSnowTransition.TabIndex = 64
        Me.nSnowTransition.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'gTrees
        '
        Me.gTrees.Controls.Add(Me.xGiantTrees)
        Me.gTrees.Controls.Add(Me.lTreeHeightUnits)
        Me.gTrees.Controls.Add(Me.nTreeHeightVariation)
        Me.gTrees.Controls.Add(Me.lTreeHeightVariation)
        Me.gTrees.Controls.Add(Me.nTreeHeight)
        Me.gTrees.Controls.Add(Me.lTreeHeight)
        Me.gTrees.Controls.Add(Me.lTreeSpacingUnits)
        Me.gTrees.Controls.Add(Me.nTreeSpacingVariation)
        Me.gTrees.Controls.Add(Me.lTreeSpacingVariation)
        Me.gTrees.Controls.Add(Me.nTreeSpacing)
        Me.gTrees.Controls.Add(Me.lTreeSpacing)
        Me.gTrees.Location = New System.Drawing.Point(3, 730)
        Me.gTrees.Name = "gTrees"
        Me.gTrees.Size = New System.Drawing.Size(362, 75)
        Me.gTrees.TabIndex = 12
        Me.gTrees.TabStop = False
        Me.gTrees.Text = "Trees"
        Me.gTrees.Visible = False
        '
        'xGiantTrees
        '
        Me.xGiantTrees.AutoSize = True
        Me.xGiantTrees.Location = New System.Drawing.Point(260, 20)
        Me.xGiantTrees.Name = "xGiantTrees"
        Me.xGiantTrees.Size = New System.Drawing.Size(77, 17)
        Me.xGiantTrees.TabIndex = 68
        Me.xGiantTrees.Text = "Giant trees"
        Me.xGiantTrees.UseVisualStyleBackColor = True
        '
        'lTreeHeightUnits
        '
        Me.lTreeHeightUnits.AutoSize = True
        Me.lTreeHeightUnits.Location = New System.Drawing.Point(211, 47)
        Me.lTreeHeightUnits.Name = "lTreeHeightUnits"
        Me.lTreeHeightUnits.Size = New System.Drawing.Size(38, 13)
        Me.lTreeHeightUnits.TabIndex = 67
        Me.lTreeHeightUnits.Text = "blocks"
        '
        'nTreeHeightVariation
        '
        Me.nTreeHeightVariation.Location = New System.Drawing.Point(160, 45)
        Me.nTreeHeightVariation.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.nTreeHeightVariation.Name = "nTreeHeightVariation"
        Me.nTreeHeightVariation.Size = New System.Drawing.Size(45, 20)
        Me.nTreeHeightVariation.TabIndex = 3
        Me.nTreeHeightVariation.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lTreeHeightVariation
        '
        Me.lTreeHeightVariation.AutoSize = True
        Me.lTreeHeightVariation.Location = New System.Drawing.Point(133, 47)
        Me.lTreeHeightVariation.Name = "lTreeHeightVariation"
        Me.lTreeHeightVariation.Size = New System.Drawing.Size(21, 13)
        Me.lTreeHeightVariation.TabIndex = 65
        Me.lTreeHeightVariation.Text = "+/-"
        '
        'nTreeHeight
        '
        Me.nTreeHeight.Location = New System.Drawing.Point(83, 45)
        Me.nTreeHeight.Maximum = New Decimal(New Integer() {64, 0, 0, 0})
        Me.nTreeHeight.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nTreeHeight.Name = "nTreeHeight"
        Me.nTreeHeight.Size = New System.Drawing.Size(44, 20)
        Me.nTreeHeight.TabIndex = 2
        Me.nTreeHeight.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'lTreeHeight
        '
        Me.lTreeHeight.AutoSize = True
        Me.lTreeHeight.Location = New System.Drawing.Point(14, 47)
        Me.lTreeHeight.Name = "lTreeHeight"
        Me.lTreeHeight.Size = New System.Drawing.Size(61, 13)
        Me.lTreeHeight.TabIndex = 64
        Me.lTreeHeight.Text = "Tree height"
        '
        'lTreeSpacingUnits
        '
        Me.lTreeSpacingUnits.AutoSize = True
        Me.lTreeSpacingUnits.Location = New System.Drawing.Point(211, 21)
        Me.lTreeSpacingUnits.Name = "lTreeSpacingUnits"
        Me.lTreeSpacingUnits.Size = New System.Drawing.Size(38, 13)
        Me.lTreeSpacingUnits.TabIndex = 62
        Me.lTreeSpacingUnits.Text = "blocks"
        '
        'nTreeSpacingVariation
        '
        Me.nTreeSpacingVariation.Location = New System.Drawing.Point(160, 19)
        Me.nTreeSpacingVariation.Maximum = New Decimal(New Integer() {512, 0, 0, 0})
        Me.nTreeSpacingVariation.Name = "nTreeSpacingVariation"
        Me.nTreeSpacingVariation.Size = New System.Drawing.Size(45, 20)
        Me.nTreeSpacingVariation.TabIndex = 1
        Me.nTreeSpacingVariation.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'lTreeSpacingVariation
        '
        Me.lTreeSpacingVariation.AutoSize = True
        Me.lTreeSpacingVariation.Location = New System.Drawing.Point(133, 21)
        Me.lTreeSpacingVariation.Name = "lTreeSpacingVariation"
        Me.lTreeSpacingVariation.Size = New System.Drawing.Size(21, 13)
        Me.lTreeSpacingVariation.TabIndex = 60
        Me.lTreeSpacingVariation.Text = "+/-"
        '
        'nTreeSpacing
        '
        Me.nTreeSpacing.Location = New System.Drawing.Point(83, 19)
        Me.nTreeSpacing.Maximum = New Decimal(New Integer() {1024, 0, 0, 0})
        Me.nTreeSpacing.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nTreeSpacing.Name = "nTreeSpacing"
        Me.nTreeSpacing.Size = New System.Drawing.Size(44, 20)
        Me.nTreeSpacing.TabIndex = 0
        Me.nTreeSpacing.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'lTreeSpacing
        '
        Me.lTreeSpacing.AutoSize = True
        Me.lTreeSpacing.Location = New System.Drawing.Point(6, 21)
        Me.lTreeSpacing.Name = "lTreeSpacing"
        Me.lTreeSpacing.Size = New System.Drawing.Size(69, 13)
        Me.lTreeSpacing.TabIndex = 59
        Me.lTreeSpacing.Text = "Tree spacing"
        '
        'gSnow
        '
        Me.gSnow.Controls.Add(Me.lSnowTransitionUnits)
        Me.gSnow.Controls.Add(Me.lSnowTransition)
        Me.gSnow.Controls.Add(Me.lSnowAltitudeUnits)
        Me.gSnow.Controls.Add(Me.nSnowTransition)
        Me.gSnow.Controls.Add(Me.nSnowAltitude)
        Me.gSnow.Controls.Add(Me.lSnowAltitude)
        Me.gSnow.Location = New System.Drawing.Point(3, 811)
        Me.gSnow.Name = "gSnow"
        Me.gSnow.Size = New System.Drawing.Size(362, 45)
        Me.gSnow.TabIndex = 24
        Me.gSnow.TabStop = False
        Me.gSnow.Text = "Snowy Mountains"
        Me.gSnow.Visible = False
        '
        'nSnowAltitude
        '
        Me.nSnowAltitude.Location = New System.Drawing.Point(83, 19)
        Me.nSnowAltitude.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nSnowAltitude.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nSnowAltitude.Name = "nSnowAltitude"
        Me.nSnowAltitude.Size = New System.Drawing.Size(54, 20)
        Me.nSnowAltitude.TabIndex = 63
        Me.nSnowAltitude.Value = New Decimal(New Integer() {40, 0, 0, 0})
        '
        'lSnowAltitude
        '
        Me.lSnowAltitude.AutoSize = True
        Me.lSnowAltitude.Location = New System.Drawing.Point(6, 21)
        Me.lSnowAltitude.Name = "lSnowAltitude"
        Me.lSnowAltitude.Size = New System.Drawing.Size(71, 13)
        Me.lSnowAltitude.TabIndex = 65
        Me.lSnowAltitude.Text = "Snow altitude"
        '
        'xAddSnow
        '
        Me.xAddSnow.AutoSize = True
        Me.xAddSnow.Location = New System.Drawing.Point(110, 42)
        Me.xAddSnow.Name = "xAddSnow"
        Me.xAddSnow.Size = New System.Drawing.Size(109, 17)
        Me.xAddSnow.TabIndex = 24
        Me.xAddSnow.Text = "Snowy mountains"
        Me.xAddSnow.UseVisualStyleBackColor = True
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.progressBar, Me.tStatus1, Me.tStatus2})
        Me.statusStrip.Location = New System.Drawing.Point(0, 561)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(984, 22)
        Me.statusStrip.TabIndex = 31
        Me.statusStrip.Text = "statusStrip1"
        '
        'progressBar
        '
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(100, 16)
        Me.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.progressBar.Visible = False
        '
        'tStatus1
        '
        Me.tStatus1.Name = "tStatus1"
        Me.tStatus1.Size = New System.Drawing.Size(43, 17)
        Me.tStatus1.Text = "status1"
        '
        'tStatus2
        '
        Me.tStatus2.Name = "tStatus2"
        Me.tStatus2.Size = New System.Drawing.Size(43, 17)
        Me.tStatus2.Text = "status2"
        '
        'tName
        '
        Me.tName.Location = New System.Drawing.Point(113, 6)
        Me.tName.Name = "tName"
        Me.tName.Size = New System.Drawing.Size(113, 20)
        Me.tName.TabIndex = 19
        '
        'lBackup
        '
        Me.lBackup.AutoSize = True
        Me.lBackup.Location = New System.Drawing.Point(243, 9)
        Me.lBackup.Name = "lBackup"
        Me.lBackup.Size = New System.Drawing.Size(44, 13)
        Me.lBackup.TabIndex = 24
        Me.lBackup.Text = "Backup"
        '
        'lBuild
        '
        Me.lBuild.AutoSize = True
        Me.lBuild.Location = New System.Drawing.Point(25, 62)
        Me.lBuild.Name = "lBuild"
        Me.lBuild.Size = New System.Drawing.Size(82, 13)
        Me.lBuild.TabIndex = 22
        Me.lBuild.Text = "Build permission"
        '
        'bPreviewPrev
        '
        Me.bPreviewPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bPreviewPrev.Location = New System.Drawing.Point(222, 490)
        Me.bPreviewPrev.Name = "bPreviewPrev"
        Me.bPreviewPrev.Size = New System.Drawing.Size(22, 22)
        Me.bPreviewPrev.TabIndex = 0
        Me.bPreviewPrev.Text = "<"
        Me.bPreviewPrev.UseVisualStyleBackColor = True
        '
        'previewLayout
        '
        Me.previewLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.previewLayout.ColumnCount = 3
        Me.previewLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.previewLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.previewLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.previewLayout.Controls.Add(Me.bPreviewPrev, 0, 1)
        Me.previewLayout.Controls.Add(Me.bPreviewNext, 2, 1)
        Me.previewLayout.Controls.Add(Me.lPreview, 1, 1)
        Me.previewLayout.Location = New System.Drawing.Point(417, 6)
        Me.previewLayout.Name = "previewLayout"
        Me.previewLayout.RowCount = 2
        Me.previewLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.previewLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.previewLayout.Size = New System.Drawing.Size(555, 515)
        Me.previewLayout.TabIndex = 30
        '
        'bPreviewNext
        '
        Me.bPreviewNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bPreviewNext.Location = New System.Drawing.Point(310, 490)
        Me.bPreviewNext.Name = "bPreviewNext"
        Me.bPreviewNext.Size = New System.Drawing.Size(22, 22)
        Me.bPreviewNext.TabIndex = 2
        Me.bPreviewNext.Text = ">"
        Me.bPreviewNext.UseVisualStyleBackColor = True
        '
        'lPreview
        '
        Me.lPreview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lPreview.AutoSize = True
        Me.lPreview.Location = New System.Drawing.Point(250, 487)
        Me.lPreview.Name = "lPreview"
        Me.lPreview.Size = New System.Drawing.Size(54, 28)
        Me.lPreview.TabIndex = 1
        Me.lPreview.Text = "Preview"
        Me.lPreview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'xHidden
        '
        Me.xHidden.AutoSize = True
        Me.xHidden.Location = New System.Drawing.Point(246, 34)
        Me.xHidden.Name = "xHidden"
        Me.xHidden.Size = New System.Drawing.Size(132, 17)
        Me.xHidden.TabIndex = 26
        Me.xHidden.Text = "Hide from the world list"
        Me.xHidden.UseVisualStyleBackColor = True
        '
        'lAccess
        '
        Me.lAccess.AutoSize = True
        Me.lAccess.Location = New System.Drawing.Point(13, 35)
        Me.lAccess.Name = "lAccess"
        Me.lAccess.Size = New System.Drawing.Size(94, 13)
        Me.lAccess.TabIndex = 20
        Me.lAccess.Text = "Access permission"
        '
        'lName
        '
        Me.lName.AutoSize = True
        Me.lName.Location = New System.Drawing.Point(43, 9)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(64, 13)
        Me.lName.TabIndex = 18
        Me.lName.Text = "World name"
        '
        'cBuild
        '
        Me.cBuild.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBuild.FormattingEnabled = True
        Me.cBuild.Location = New System.Drawing.Point(113, 59)
        Me.cBuild.Name = "cBuild"
        Me.cBuild.Size = New System.Drawing.Size(113, 21)
        Me.cBuild.TabIndex = 23
        '
        'bShow
        '
        Me.bShow.Location = New System.Drawing.Point(305, 6)
        Me.bShow.Name = "bShow"
        Me.bShow.Size = New System.Drawing.Size(74, 23)
        Me.bShow.TabIndex = 2
        Me.bShow.Text = "Show"
        Me.bShow.UseVisualStyleBackColor = True
        '
        'xFloodBarrier
        '
        Me.xFloodBarrier.AutoSize = True
        Me.xFloodBarrier.Location = New System.Drawing.Point(254, 65)
        Me.xFloodBarrier.Name = "xFloodBarrier"
        Me.xFloodBarrier.Size = New System.Drawing.Size(84, 17)
        Me.xFloodBarrier.TabIndex = 4
        Me.xFloodBarrier.Text = "Flood barrier"
        Me.xFloodBarrier.UseVisualStyleBackColor = True
        '
        'bGenerate
        '
        Me.bGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGenerate.Location = New System.Drawing.Point(6, 6)
        Me.bGenerate.Name = "bGenerate"
        Me.bGenerate.Size = New System.Drawing.Size(95, 47)
        Me.bGenerate.TabIndex = 0
        Me.bGenerate.Text = "Generate"
        Me.bGenerate.UseVisualStyleBackColor = True
        '
        'lTheme
        '
        Me.lTheme.AutoSize = True
        Me.lTheme.Location = New System.Drawing.Point(235, 9)
        Me.lTheme.Name = "lTheme"
        Me.lTheme.Size = New System.Drawing.Size(40, 13)
        Me.lTheme.TabIndex = 19
        Me.lTheme.Text = "Theme"
        '
        'cTheme
        '
        Me.cTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cTheme.Location = New System.Drawing.Point(281, 6)
        Me.cTheme.Name = "cTheme"
        Me.cTheme.Size = New System.Drawing.Size(87, 21)
        Me.cTheme.TabIndex = 3
        '
        'cWorld
        '
        Me.cWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cWorld.FormattingEnabled = True
        Me.cWorld.Location = New System.Drawing.Point(85, 7)
        Me.cWorld.Name = "cWorld"
        Me.cWorld.Size = New System.Drawing.Size(214, 21)
        Me.cWorld.TabIndex = 1
        '
        'tFile
        '
        Me.tFile.Location = New System.Drawing.Point(72, 87)
        Me.tFile.Name = "tFile"
        Me.tFile.ReadOnly = True
        Me.tFile.Size = New System.Drawing.Size(233, 20)
        Me.tFile.TabIndex = 3
        '
        'bBrowseFile
        '
        Me.bBrowseFile.Location = New System.Drawing.Point(311, 85)
        Me.bBrowseFile.Name = "bBrowseFile"
        Me.bBrowseFile.Size = New System.Drawing.Size(74, 23)
        Me.bBrowseFile.TabIndex = 4
        Me.bBrowseFile.Text = "Browse"
        Me.bBrowseFile.UseVisualStyleBackColor = True
        '
        'cBackup
        '
        Me.cBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBackup.FormattingEnabled = True
        Me.cBackup.Location = New System.Drawing.Point(293, 6)
        Me.cBackup.Name = "cBackup"
        Me.cBackup.Size = New System.Drawing.Size(93, 21)
        Me.cBackup.TabIndex = 25
        '
        'bCancel
        '
        Me.bCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bCancel.Location = New System.Drawing.Point(872, 527)
        Me.bCancel.Name = "bCancel"
        Me.bCancel.Size = New System.Drawing.Size(100, 25)
        Me.bCancel.TabIndex = 35
        Me.bCancel.Text = "Cancel"
        Me.bCancel.UseVisualStyleBackColor = True
        '
        'bOK
        '
        Me.bOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bOK.Location = New System.Drawing.Point(766, 527)
        Me.bOK.Name = "bOK"
        Me.bOK.Size = New System.Drawing.Size(100, 25)
        Me.bOK.TabIndex = 34
        Me.bOK.Text = "OK"
        Me.bOK.UseVisualStyleBackColor = True
        '
        'cAccess
        '
        Me.cAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cAccess.FormattingEnabled = True
        Me.cAccess.Location = New System.Drawing.Point(113, 32)
        Me.cAccess.Name = "cAccess"
        Me.cAccess.Size = New System.Drawing.Size(113, 21)
        Me.cAccess.TabIndex = 21
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(211, 3)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(151, 65)
        Me.label3.TabIndex = 1
        Me.label3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- MinerCPP and LuaCraft (.dat)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- D3 (.map)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- JTE's (.gz)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- OptiCraft (.save)" & _
    ""
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(6, 126)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(173, 26)
        Me.label2.TabIndex = 5
        Me.label2.Text = "Supported folder formats:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Myne, MyneCraft, Hyvebuilt, iCraft"
        '
        'tFolder
        '
        Me.tFolder.Location = New System.Drawing.Point(72, 159)
        Me.tFolder.Name = "tFolder"
        Me.tFolder.ReadOnly = True
        Me.tFolder.Size = New System.Drawing.Size(233, 20)
        Me.tFolder.TabIndex = 7
        '
        'tabCopy
        '
        Me.tabCopy.Controls.Add(Me.tCopyInfo)
        Me.tabCopy.Controls.Add(Me.lWorldToCopy)
        Me.tabCopy.Controls.Add(Me.bShow)
        Me.tabCopy.Controls.Add(Me.cWorld)
        Me.tabCopy.Location = New System.Drawing.Point(4, 22)
        Me.tabCopy.Name = "tabCopy"
        Me.tabCopy.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCopy.Size = New System.Drawing.Size(391, 422)
        Me.tabCopy.TabIndex = 2
        Me.tabCopy.Text = "Copy World"
        Me.tabCopy.UseVisualStyleBackColor = True
        '
        'tCopyInfo
        '
        Me.tCopyInfo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tCopyInfo.Location = New System.Drawing.Point(6, 34)
        Me.tCopyInfo.Multiline = True
        Me.tCopyInfo.Name = "tCopyInfo"
        Me.tCopyInfo.ReadOnly = True
        Me.tCopyInfo.Size = New System.Drawing.Size(373, 100)
        Me.tCopyInfo.TabIndex = 3
        '
        'lWorldToCopy
        '
        Me.lWorldToCopy.AutoSize = True
        Me.lWorldToCopy.Location = New System.Drawing.Point(6, 11)
        Me.lWorldToCopy.Name = "lWorldToCopy"
        Me.lWorldToCopy.Size = New System.Drawing.Size(73, 13)
        Me.lWorldToCopy.TabIndex = 0
        Me.lWorldToCopy.Text = "World to copy"
        '
        'tabFlatgrass
        '
        Me.tabFlatgrass.Controls.Add(Me.bFlatgrassGenerate)
        Me.tabFlatgrass.Controls.Add(Me.nFlatgrassDimX)
        Me.tabFlatgrass.Controls.Add(Me.lFlatgrassX1)
        Me.tabFlatgrass.Controls.Add(Me.lFlatgrassDimensions)
        Me.tabFlatgrass.Controls.Add(Me.lFlatgrassX2)
        Me.tabFlatgrass.Controls.Add(Me.nFlatgrassDimZ)
        Me.tabFlatgrass.Controls.Add(Me.nFlatgrassDimY)
        Me.tabFlatgrass.Location = New System.Drawing.Point(4, 22)
        Me.tabFlatgrass.Name = "tabFlatgrass"
        Me.tabFlatgrass.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFlatgrass.Size = New System.Drawing.Size(391, 422)
        Me.tabFlatgrass.TabIndex = 3
        Me.tabFlatgrass.Text = "Flatgrass"
        Me.tabFlatgrass.UseVisualStyleBackColor = True
        '
        'bFlatgrassGenerate
        '
        Me.bFlatgrassGenerate.Location = New System.Drawing.Point(6, 6)
        Me.bFlatgrassGenerate.Name = "bFlatgrassGenerate"
        Me.bFlatgrassGenerate.Size = New System.Drawing.Size(74, 50)
        Me.bFlatgrassGenerate.TabIndex = 0
        Me.bFlatgrassGenerate.Text = "Generate"
        Me.bFlatgrassGenerate.UseVisualStyleBackColor = True
        '
        'nFlatgrassDimX
        '
        Me.nFlatgrassDimX.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nFlatgrassDimX.Location = New System.Drawing.Point(153, 23)
        Me.nFlatgrassDimX.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nFlatgrassDimX.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nFlatgrassDimX.Name = "nFlatgrassDimX"
        Me.nFlatgrassDimX.Size = New System.Drawing.Size(54, 20)
        Me.nFlatgrassDimX.TabIndex = 2
        Me.nFlatgrassDimX.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'lFlatgrassX1
        '
        Me.lFlatgrassX1.AutoSize = True
        Me.lFlatgrassX1.Location = New System.Drawing.Point(213, 25)
        Me.lFlatgrassX1.Name = "lFlatgrassX1"
        Me.lFlatgrassX1.Size = New System.Drawing.Size(13, 13)
        Me.lFlatgrassX1.TabIndex = 3
        Me.lFlatgrassX1.Text = "×"
        '
        'lFlatgrassDimensions
        '
        Me.lFlatgrassDimensions.AutoSize = True
        Me.lFlatgrassDimensions.Location = New System.Drawing.Point(86, 25)
        Me.lFlatgrassDimensions.Name = "lFlatgrassDimensions"
        Me.lFlatgrassDimensions.Size = New System.Drawing.Size(61, 13)
        Me.lFlatgrassDimensions.TabIndex = 1
        Me.lFlatgrassDimensions.Text = "Dimensions"
        '
        'lFlatgrassX2
        '
        Me.lFlatgrassX2.AutoSize = True
        Me.lFlatgrassX2.Location = New System.Drawing.Point(292, 25)
        Me.lFlatgrassX2.Name = "lFlatgrassX2"
        Me.lFlatgrassX2.Size = New System.Drawing.Size(13, 13)
        Me.lFlatgrassX2.TabIndex = 5
        Me.lFlatgrassX2.Text = "×"
        '
        'nFlatgrassDimZ
        '
        Me.nFlatgrassDimZ.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nFlatgrassDimZ.Location = New System.Drawing.Point(311, 23)
        Me.nFlatgrassDimZ.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nFlatgrassDimZ.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nFlatgrassDimZ.Name = "nFlatgrassDimZ"
        Me.nFlatgrassDimZ.Size = New System.Drawing.Size(54, 20)
        Me.nFlatgrassDimZ.TabIndex = 6
        Me.nFlatgrassDimZ.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'nFlatgrassDimY
        '
        Me.nFlatgrassDimY.Increment = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nFlatgrassDimY.Location = New System.Drawing.Point(232, 23)
        Me.nFlatgrassDimY.Maximum = New Decimal(New Integer() {2032, 0, 0, 0})
        Me.nFlatgrassDimY.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.nFlatgrassDimY.Name = "nFlatgrassDimY"
        Me.nFlatgrassDimY.Size = New System.Drawing.Size(54, 20)
        Me.nFlatgrassDimY.TabIndex = 4
        Me.nFlatgrassDimY.Value = New Decimal(New Integer() {64, 0, 0, 0})
        '
        'tabTerrain
        '
        Me.tabTerrain.BackColor = System.Drawing.SystemColors.Window
        Me.tabTerrain.Controls.Add(Me.flowLayoutPanel1)
        Me.tabTerrain.Controls.Add(Me.xSeed)
        Me.tabTerrain.Controls.Add(Me.nSeed)
        Me.tabTerrain.Controls.Add(Me.xAdvanced)
        Me.tabTerrain.Controls.Add(Me.bGenerate)
        Me.tabTerrain.Controls.Add(Me.lTheme)
        Me.tabTerrain.Controls.Add(Me.cTheme)
        Me.tabTerrain.Location = New System.Drawing.Point(4, 22)
        Me.tabTerrain.Name = "tabTerrain"
        Me.tabTerrain.Padding = New System.Windows.Forms.Padding(3)
        Me.tabTerrain.Size = New System.Drawing.Size(391, 422)
        Me.tabTerrain.TabIndex = 5
        Me.tabTerrain.Text = "Generator"
        Me.tabTerrain.UseVisualStyleBackColor = True
        '
        'flowLayoutPanel1
        '
        Me.flowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flowLayoutPanel1.AutoScroll = True
        Me.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.flowLayoutPanel1.Controls.Add(Me.gGenOptions)
        Me.flowLayoutPanel1.Controls.Add(Me.gTemplates)
        Me.flowLayoutPanel1.Controls.Add(Me.gMapSize)
        Me.flowLayoutPanel1.Controls.Add(Me.gTerrainFeatures)
        Me.flowLayoutPanel1.Controls.Add(Me.gHeightmapCreation)
        Me.flowLayoutPanel1.Controls.Add(Me.gCaves)
        Me.flowLayoutPanel1.Controls.Add(Me.gTrees)
        Me.flowLayoutPanel1.Controls.Add(Me.gSnow)
        Me.flowLayoutPanel1.Controls.Add(Me.gCliffs)
        Me.flowLayoutPanel1.Controls.Add(Me.gBeaches)
        Me.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flowLayoutPanel1.Location = New System.Drawing.Point(0, 59)
        Me.flowLayoutPanel1.Name = "flowLayoutPanel1"
        Me.flowLayoutPanel1.Size = New System.Drawing.Size(391, 365)
        Me.flowLayoutPanel1.TabIndex = 57
        Me.flowLayoutPanel1.WrapContents = False
        '
        'gGenOptions
        '
        Me.gGenOptions.Controls.Add(Me.xAddCliffs)
        Me.gGenOptions.Controls.Add(Me.xAddRuins)
        Me.gGenOptions.Controls.Add(Me.xOre)
        Me.gGenOptions.Controls.Add(Me.xAddBeaches)
        Me.gGenOptions.Controls.Add(Me.xAddTrees)
        Me.gGenOptions.Controls.Add(Me.xAddSnow)
        Me.gGenOptions.Controls.Add(Me.xFloodBarrier)
        Me.gGenOptions.Controls.Add(Me.xWater)
        Me.gGenOptions.Controls.Add(Me.xCaves)
        Me.gGenOptions.Location = New System.Drawing.Point(3, 3)
        Me.gGenOptions.Name = "gGenOptions"
        Me.gGenOptions.Size = New System.Drawing.Size(362, 91)
        Me.gGenOptions.TabIndex = 22
        Me.gGenOptions.TabStop = False
        Me.gGenOptions.Text = "Optional Modules"
        '
        'xWater
        '
        Me.xWater.AutoSize = True
        Me.xWater.Checked = True
        Me.xWater.CheckState = System.Windows.Forms.CheckState.Checked
        Me.xWater.Location = New System.Drawing.Point(13, 42)
        Me.xWater.Name = "xWater"
        Me.xWater.Size = New System.Drawing.Size(55, 17)
        Me.xWater.TabIndex = 20
        Me.xWater.Text = "Water"
        Me.xWater.UseVisualStyleBackColor = True
        '
        'xCaves
        '
        Me.xCaves.AutoSize = True
        Me.xCaves.Location = New System.Drawing.Point(13, 65)
        Me.xCaves.Name = "xCaves"
        Me.xCaves.Size = New System.Drawing.Size(56, 17)
        Me.xCaves.TabIndex = 23
        Me.xCaves.Text = "Caves"
        Me.xCaves.UseVisualStyleBackColor = True
        '
        'folderBrowser
        '
        Me.folderBrowser.Description = "Find the folder where your Myne / MyneCraft / Hydebuild / iCraft map is located."
        '
        'lFolder
        '
        Me.lFolder.AutoSize = True
        Me.lFolder.Location = New System.Drawing.Point(6, 162)
        Me.lFolder.Name = "lFolder"
        Me.lFolder.Size = New System.Drawing.Size(60, 13)
        Me.lFolder.TabIndex = 6
        Me.lFolder.Text = "Load folder"
        '
        'bBrowseFolder
        '
        Me.bBrowseFolder.Location = New System.Drawing.Point(311, 156)
        Me.bBrowseFolder.Name = "bBrowseFolder"
        Me.bBrowseFolder.Size = New System.Drawing.Size(74, 23)
        Me.bBrowseFolder.TabIndex = 8
        Me.bBrowseFolder.Text = "Browse"
        Me.bBrowseFolder.UseVisualStyleBackColor = True
        '
        'tabs
        '
        Me.tabs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tabs.Controls.Add(Me.tabExisting)
        Me.tabs.Controls.Add(Me.tabLoad)
        Me.tabs.Controls.Add(Me.tabCopy)
        Me.tabs.Controls.Add(Me.tabFlatgrass)
        Me.tabs.Controls.Add(Me.tabTerrain)
        Me.tabs.Location = New System.Drawing.Point(12, 104)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(399, 448)
        Me.tabs.TabIndex = 29
        '
        'tabExisting
        '
        Me.tabExisting.Controls.Add(Me.tExistingMapInfo)
        Me.tabExisting.Location = New System.Drawing.Point(4, 22)
        Me.tabExisting.Name = "tabExisting"
        Me.tabExisting.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExisting.Size = New System.Drawing.Size(391, 422)
        Me.tabExisting.TabIndex = 0
        Me.tabExisting.Text = "Existing Map"
        Me.tabExisting.UseVisualStyleBackColor = True
        '
        'tExistingMapInfo
        '
        Me.tExistingMapInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tExistingMapInfo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tExistingMapInfo.Location = New System.Drawing.Point(6, 6)
        Me.tExistingMapInfo.Multiline = True
        Me.tExistingMapInfo.Name = "tExistingMapInfo"
        Me.tExistingMapInfo.ReadOnly = True
        Me.tExistingMapInfo.Size = New System.Drawing.Size(373, 410)
        Me.tExistingMapInfo.TabIndex = 0
        Me.tExistingMapInfo.TabStop = False
        '
        'tabLoad
        '
        Me.tabLoad.Controls.Add(Me.label3)
        Me.tabLoad.Controls.Add(Me.label2)
        Me.tabLoad.Controls.Add(Me.lFolder)
        Me.tabLoad.Controls.Add(Me.tFolder)
        Me.tabLoad.Controls.Add(Me.bBrowseFolder)
        Me.tabLoad.Controls.Add(Me.lFormatList)
        Me.tabLoad.Controls.Add(Me.lFile)
        Me.tabLoad.Controls.Add(Me.tLoadFileInfo)
        Me.tabLoad.Controls.Add(Me.tFile)
        Me.tabLoad.Controls.Add(Me.bBrowseFile)
        Me.tabLoad.Location = New System.Drawing.Point(4, 22)
        Me.tabLoad.Name = "tabLoad"
        Me.tabLoad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLoad.Size = New System.Drawing.Size(391, 422)
        Me.tabLoad.TabIndex = 1
        Me.tabLoad.Text = "Load File"
        Me.tabLoad.UseVisualStyleBackColor = True
        '
        'lFormatList
        '
        Me.lFormatList.AutoSize = True
        Me.lFormatList.Location = New System.Drawing.Point(6, 3)
        Me.lFormatList.Name = "lFormatList"
        Me.lFormatList.Size = New System.Drawing.Size(144, 78)
        Me.lFormatList.TabIndex = 0
        Me.lFormatList.Text = "Supported file formats:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- fCraft and SpaceCraft (.fcm)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- MCSharp and MCZall (.l" & _
    "vl)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Creative (original .dat)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Survival Test (.mine)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Survival Indev (.mcl" & _
    "evel)"
        '
        'lFile
        '
        Me.lFile.AutoSize = True
        Me.lFile.Location = New System.Drawing.Point(6, 90)
        Me.lFile.Name = "lFile"
        Me.lFile.Size = New System.Drawing.Size(47, 13)
        Me.lFile.TabIndex = 2
        Me.lFile.Text = "Load file"
        '
        'tLoadFileInfo
        '
        Me.tLoadFileInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tLoadFileInfo.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tLoadFileInfo.Location = New System.Drawing.Point(3, 185)
        Me.tLoadFileInfo.Multiline = True
        Me.tLoadFileInfo.Name = "tLoadFileInfo"
        Me.tLoadFileInfo.ReadOnly = True
        Me.tLoadFileInfo.Size = New System.Drawing.Size(379, 233)
        Me.tLoadFileInfo.TabIndex = 9
        Me.tLoadFileInfo.TabStop = False
        '
        'bSavePreview
        '
        Me.bSavePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bSavePreview.Enabled = False
        Me.bSavePreview.Location = New System.Drawing.Point(417, 527)
        Me.bSavePreview.Name = "bSavePreview"
        Me.bSavePreview.Size = New System.Drawing.Size(125, 25)
        Me.bSavePreview.TabIndex = 32
        Me.bSavePreview.Text = "Save Preview Image..."
        Me.bSavePreview.UseVisualStyleBackColor = True
        '
        'AddWorldPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 583)
        Me.Controls.Add(Me.lCreateMap)
        Me.Controls.Add(Me.lMapFileOptions)
        Me.Controls.Add(Me.xBlockDB)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.tName)
        Me.Controls.Add(Me.lBackup)
        Me.Controls.Add(Me.lBuild)
        Me.Controls.Add(Me.previewLayout)
        Me.Controls.Add(Me.xHidden)
        Me.Controls.Add(Me.lAccess)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.cBuild)
        Me.Controls.Add(Me.cBackup)
        Me.Controls.Add(Me.bCancel)
        Me.Controls.Add(Me.bOK)
        Me.Controls.Add(Me.cAccess)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.bSavePreview)
        Me.Name = "AddWorldPopup"
        Me.Text = "AddWorldPopup"
        Me.gTerrainFeatures.ResumeLayout(False)
        Me.gTerrainFeatures.PerformLayout()
        CType(Me.nLoweredCorners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nRaisedCorners, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sBias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gHeightmapCreation.ResumeLayout(False)
        Me.gHeightmapCreation.PerformLayout()
        CType(Me.sAboveFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sBelowFunc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sDetailScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sFeatureScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sWaterCoverage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sRoughness, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gCaves.ResumeLayout(False)
        Me.gCaves.PerformLayout()
        CType(Me.sCaveSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sCaveDensity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gTemplates.ResumeLayout(False)
        Me.gTemplates.PerformLayout()
        Me.gMapSize.ResumeLayout(False)
        Me.gMapSize.PerformLayout()
        CType(Me.nMaxDepthVariation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxHeightVariation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nWaterLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxDepth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMaxHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMapWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMapHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nMapLength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gCliffs.ResumeLayout(False)
        Me.gCliffs.PerformLayout()
        CType(Me.sCliffThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBeaches.ResumeLayout(False)
        Me.gBeaches.PerformLayout()
        CType(Me.nBeachHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nBeachExtent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nSnowTransition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gTrees.ResumeLayout(False)
        Me.gTrees.PerformLayout()
        CType(Me.nTreeHeightVariation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nTreeHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nTreeSpacingVariation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nTreeSpacing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gSnow.ResumeLayout(False)
        Me.gSnow.PerformLayout()
        CType(Me.nSnowAltitude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statusStrip.ResumeLayout(False)
        Me.statusStrip.PerformLayout()
        Me.previewLayout.ResumeLayout(False)
        Me.previewLayout.PerformLayout()
        Me.tabCopy.ResumeLayout(False)
        Me.tabCopy.PerformLayout()
        Me.tabFlatgrass.ResumeLayout(False)
        Me.tabFlatgrass.PerformLayout()
        CType(Me.nFlatgrassDimX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nFlatgrassDimZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nFlatgrassDimY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTerrain.ResumeLayout(False)
        Me.tabTerrain.PerformLayout()
        Me.flowLayoutPanel1.ResumeLayout(False)
        Me.gGenOptions.ResumeLayout(False)
        Me.gGenOptions.PerformLayout()
        Me.tabs.ResumeLayout(False)
        Me.tabExisting.ResumeLayout(False)
        Me.tabExisting.PerformLayout()
        Me.tabLoad.ResumeLayout(False)
        Me.tabLoad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents gTerrainFeatures As System.Windows.Forms.GroupBox
    Private WithEvents lLoweredCorners As System.Windows.Forms.Label
    Private WithEvents nLoweredCorners As System.Windows.Forms.NumericUpDown
    Private WithEvents cMidpoint As System.Windows.Forms.ComboBox
    Private WithEvents lMidpoint As System.Windows.Forms.Label
    Private WithEvents lRaisedCorners As System.Windows.Forms.Label
    Private WithEvents nRaisedCorners As System.Windows.Forms.NumericUpDown
    Private WithEvents lBiasDisplay As System.Windows.Forms.Label
    Private WithEvents lBias As System.Windows.Forms.Label
    Private WithEvents sBias As System.Windows.Forms.TrackBar
    Private WithEvents lCaveSizeDisplay As System.Windows.Forms.Label
    Private WithEvents gHeightmapCreation As System.Windows.Forms.GroupBox
    Private WithEvents lBelowFunc As System.Windows.Forms.Label
    Private WithEvents lAboveFunc As System.Windows.Forms.Label
    Private WithEvents lBelowFuncUnits As System.Windows.Forms.Label
    Private WithEvents lAboveFuncUnits As System.Windows.Forms.Label
    Private WithEvents sAboveFunc As System.Windows.Forms.TrackBar
    Private WithEvents sBelowFunc As System.Windows.Forms.TrackBar
    Private WithEvents xDelayBias As System.Windows.Forms.CheckBox
    Private WithEvents xInvert As System.Windows.Forms.CheckBox
    Private WithEvents sDetailScale As System.Windows.Forms.TrackBar
    Private WithEvents lDetailSizeDisplay As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents sFeatureScale As System.Windows.Forms.TrackBar
    Private WithEvents lRoughnessDisplay As System.Windows.Forms.Label
    Private WithEvents lFeatureSizeDisplay As System.Windows.Forms.Label
    Private WithEvents xMatchWaterCoverage As System.Windows.Forms.CheckBox
    Private WithEvents sWaterCoverage As System.Windows.Forms.TrackBar
    Private WithEvents xLayeredHeightmap As System.Windows.Forms.CheckBox
    Private WithEvents xMarbledMode As System.Windows.Forms.CheckBox
    Private WithEvents sRoughness As System.Windows.Forms.TrackBar
    Private WithEvents lMatchWaterCoverageDisplay As System.Windows.Forms.Label
    Private WithEvents lRoughness As System.Windows.Forms.Label
    Private WithEvents lDetailSize As System.Windows.Forms.Label
    Private WithEvents xAddTrees As System.Windows.Forms.CheckBox
    Private WithEvents gCaves As System.Windows.Forms.GroupBox
    Private WithEvents lCaveDensityDisplay As System.Windows.Forms.Label
    Private WithEvents xCaveLava As System.Windows.Forms.CheckBox
    Private WithEvents xCaveWater As System.Windows.Forms.CheckBox
    Private WithEvents sCaveSize As System.Windows.Forms.TrackBar
    Private WithEvents lCaveSize As System.Windows.Forms.Label
    Private WithEvents sCaveDensity As System.Windows.Forms.TrackBar
    Private WithEvents lCaveDensity As System.Windows.Forms.Label
    Private WithEvents gTemplates As System.Windows.Forms.GroupBox
    Private WithEvents cTemplates As System.Windows.Forms.ComboBox
    Private WithEvents lUseTemplate As System.Windows.Forms.Label
    Private WithEvents bBrowseTemplate As System.Windows.Forms.Button
    Private WithEvents bSaveTemplate As System.Windows.Forms.Button
    Private WithEvents xAddCliffs As System.Windows.Forms.CheckBox
    Private WithEvents xAddRuins As System.Windows.Forms.CheckBox
    Private WithEvents xOre As System.Windows.Forms.CheckBox
    Private WithEvents xAddBeaches As System.Windows.Forms.CheckBox
    Private WithEvents gMapSize As System.Windows.Forms.GroupBox
    Private WithEvents nMaxDepthVariation As System.Windows.Forms.NumericUpDown
    Private WithEvents nMaxHeightVariation As System.Windows.Forms.NumericUpDown
    Private WithEvents lMaxHeightVariationUnits As System.Windows.Forms.Label
    Private WithEvents lMaxDepthVariationUnits As System.Windows.Forms.Label
    Private WithEvents xWaterLevel As System.Windows.Forms.CheckBox
    Private WithEvents nWaterLevel As System.Windows.Forms.NumericUpDown
    Private WithEvents lWaterLevelLabel As System.Windows.Forms.Label
    Private WithEvents nMaxDepth As System.Windows.Forms.NumericUpDown
    Private WithEvents nMaxHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents nMapWidth As System.Windows.Forms.NumericUpDown
    Private WithEvents lMaxHeight As System.Windows.Forms.Label
    Private WithEvents lMaxHeightUnits As System.Windows.Forms.Label
    Private WithEvents lMaxDepth As System.Windows.Forms.Label
    Private WithEvents lMaxDepthUnits As System.Windows.Forms.Label
    Private WithEvents lX1 As System.Windows.Forms.Label
    Private WithEvents lDim As System.Windows.Forms.Label
    Private WithEvents lX2 As System.Windows.Forms.Label
    Private WithEvents nMapHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents nMapLength As System.Windows.Forms.NumericUpDown
    Private WithEvents lSnowTransitionUnits As System.Windows.Forms.Label
    Private WithEvents lSnowAltitudeUnits As System.Windows.Forms.Label
    Private WithEvents gCliffs As System.Windows.Forms.GroupBox
    Private WithEvents xCliffSmoothing As System.Windows.Forms.CheckBox
    Private WithEvents lCliffThresholdUnits As System.Windows.Forms.Label
    Private WithEvents sCliffThreshold As System.Windows.Forms.TrackBar
    Private WithEvents lCliffThreshold As System.Windows.Forms.Label
    Private WithEvents gBeaches As System.Windows.Forms.GroupBox
    Private WithEvents lBeachHeight As System.Windows.Forms.Label
    Private WithEvents lBeachExtentUnits As System.Windows.Forms.Label
    Private WithEvents lBeachHeightUnits As System.Windows.Forms.Label
    Private WithEvents nBeachHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents nBeachExtent As System.Windows.Forms.NumericUpDown
    Private WithEvents lBeachExtent As System.Windows.Forms.Label
    Private WithEvents lSnowTransition As System.Windows.Forms.Label
    Private WithEvents xSeed As System.Windows.Forms.CheckBox
    Private WithEvents nSeed As System.Windows.Forms.NumericUpDown
    Private WithEvents xAdvanced As System.Windows.Forms.CheckBox
    Private WithEvents lCreateMap As System.Windows.Forms.Label
    Private WithEvents lMapFileOptions As System.Windows.Forms.Label
    Private WithEvents xBlockDB As System.Windows.Forms.CheckBox
    Private WithEvents nSnowTransition As System.Windows.Forms.NumericUpDown
    Private WithEvents gTrees As System.Windows.Forms.GroupBox
    Private WithEvents xGiantTrees As System.Windows.Forms.CheckBox
    Private WithEvents lTreeHeightUnits As System.Windows.Forms.Label
    Private WithEvents nTreeHeightVariation As System.Windows.Forms.NumericUpDown
    Private WithEvents lTreeHeightVariation As System.Windows.Forms.Label
    Private WithEvents nTreeHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents lTreeHeight As System.Windows.Forms.Label
    Private WithEvents lTreeSpacingUnits As System.Windows.Forms.Label
    Private WithEvents nTreeSpacingVariation As System.Windows.Forms.NumericUpDown
    Private WithEvents lTreeSpacingVariation As System.Windows.Forms.Label
    Private WithEvents nTreeSpacing As System.Windows.Forms.NumericUpDown
    Private WithEvents lTreeSpacing As System.Windows.Forms.Label
    Private WithEvents gSnow As System.Windows.Forms.GroupBox
    Private WithEvents nSnowAltitude As System.Windows.Forms.NumericUpDown
    Private WithEvents lSnowAltitude As System.Windows.Forms.Label
    Private WithEvents xAddSnow As System.Windows.Forms.CheckBox
    Private WithEvents statusStrip As System.Windows.Forms.StatusStrip
    Private WithEvents progressBar As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents tStatus1 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents tStatus2 As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents tName As System.Windows.Forms.TextBox
    Private WithEvents lBackup As System.Windows.Forms.Label
    Private WithEvents lBuild As System.Windows.Forms.Label
    Private WithEvents bPreviewPrev As System.Windows.Forms.Button
    Private WithEvents previewLayout As System.Windows.Forms.TableLayoutPanel
    Private WithEvents bPreviewNext As System.Windows.Forms.Button
    Private WithEvents lPreview As System.Windows.Forms.Label
    Private WithEvents xHidden As System.Windows.Forms.CheckBox
    Private WithEvents fileBrowser As System.Windows.Forms.OpenFileDialog
    Private WithEvents lAccess As System.Windows.Forms.Label
    Private WithEvents lName As System.Windows.Forms.Label
    Private WithEvents cBuild As System.Windows.Forms.ComboBox
    Private WithEvents bShow As System.Windows.Forms.Button
    Private WithEvents xFloodBarrier As System.Windows.Forms.CheckBox
    Private WithEvents bGenerate As System.Windows.Forms.Button
    Private WithEvents lTheme As System.Windows.Forms.Label
    Private WithEvents cTheme As System.Windows.Forms.ComboBox
    Private WithEvents cWorld As System.Windows.Forms.ComboBox
    Private WithEvents tFile As System.Windows.Forms.TextBox
    Private WithEvents bBrowseFile As System.Windows.Forms.Button
    Private WithEvents cBackup As System.Windows.Forms.ComboBox
    Private WithEvents bCancel As System.Windows.Forms.Button
    Private WithEvents bOK As System.Windows.Forms.Button
    Private WithEvents cAccess As System.Windows.Forms.ComboBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents tFolder As System.Windows.Forms.TextBox
    Private WithEvents tabCopy As System.Windows.Forms.TabPage
    Private WithEvents tCopyInfo As System.Windows.Forms.TextBox
    Private WithEvents lWorldToCopy As System.Windows.Forms.Label
    Private WithEvents tabFlatgrass As System.Windows.Forms.TabPage
    Private WithEvents bFlatgrassGenerate As System.Windows.Forms.Button
    Private WithEvents nFlatgrassDimX As System.Windows.Forms.NumericUpDown
    Private WithEvents lFlatgrassX1 As System.Windows.Forms.Label
    Private WithEvents lFlatgrassDimensions As System.Windows.Forms.Label
    Private WithEvents lFlatgrassX2 As System.Windows.Forms.Label
    Private WithEvents nFlatgrassDimZ As System.Windows.Forms.NumericUpDown
    Private WithEvents nFlatgrassDimY As System.Windows.Forms.NumericUpDown
    Private WithEvents tabTerrain As System.Windows.Forms.TabPage
    Private WithEvents flowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Private WithEvents gGenOptions As System.Windows.Forms.GroupBox
    Private WithEvents xWater As System.Windows.Forms.CheckBox
    Private WithEvents xCaves As System.Windows.Forms.CheckBox
    Private WithEvents folderBrowser As System.Windows.Forms.FolderBrowserDialog
    Private WithEvents lFolder As System.Windows.Forms.Label
    Private WithEvents bBrowseFolder As System.Windows.Forms.Button
    Private WithEvents tabs As System.Windows.Forms.TabControl
    Private WithEvents tabExisting As System.Windows.Forms.TabPage
    Private WithEvents tExistingMapInfo As System.Windows.Forms.TextBox
    Private WithEvents tabLoad As System.Windows.Forms.TabPage
    Private WithEvents lFormatList As System.Windows.Forms.Label
    Private WithEvents lFile As System.Windows.Forms.Label
    Private WithEvents tLoadFileInfo As System.Windows.Forms.TextBox
    Private WithEvents bSavePreview As System.Windows.Forms.Button
End Class
