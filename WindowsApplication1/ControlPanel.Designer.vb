<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPanel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPanel))
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lstContenidos = New System.Windows.Forms.ListView()
        Me.clmTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmFile = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.numCanciones = New System.Windows.Forms.NumericUpDown()
        Me.trackPDFZoom = New System.Windows.Forms.TrackBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.trackVideoVolume = New System.Windows.Forms.TrackBar()
        Me.chkAgregaAutomaticamente = New System.Windows.Forms.CheckBox()
        Me.btnAbreJWorg = New System.Windows.Forms.Button()
        Me.btnAbreWOL = New System.Windows.Forms.Button()
        Me.btnAbreTV = New System.Windows.Forms.Button()
        Me.btnAgregarCancionLista = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnAgregaCitaLista = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnAbreURLBuscador = New System.Windows.Forms.Button()
        Me.btnAbreSitioOficialTest = New System.Windows.Forms.Button()
        Me.btnAbreWOLTest = New System.Windows.Forms.Button()
        Me.btnAbreBroadcastingTest = New System.Windows.Forms.Button()
        Me.btnBuscaImagenFondo = New System.Windows.Forms.Button()
        Me.btnBuscaCarpetaCanciones = New System.Windows.Forms.Button()
        Me.btnCancelarConfig = New System.Windows.Forms.Button()
        Me.btnGuardarConfig = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnReestablecer = New System.Windows.Forms.Button()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnCerrarArchivo = New System.Windows.Forms.Button()
        Me.btnLimpiaItem = New System.Windows.Forms.Button()
        Me.btnValidarContenido = New System.Windows.Forms.Button()
        Me.btnBajarItem = New System.Windows.Forms.Button()
        Me.btnAbrirContenidos = New System.Windows.Forms.Button()
        Me.btnGuardarContenidos = New System.Windows.Forms.Button()
        Me.btnSubirItem = New System.Windows.Forms.Button()
        Me.btnLimpiarContenido = New System.Windows.Forms.Button()
        Me.btnReestablecePresentadorANegro = New System.Windows.Forms.Button()
        Me.btnAgregaCita = New System.Windows.Forms.Button()
        Me.btnAgregaPDF = New System.Windows.Forms.Button()
        Me.btnAgregaCancion = New System.Windows.Forms.Button()
        Me.btnAgregaVideo = New System.Windows.Forms.Button()
        Me.btnAgregaImagen = New System.Windows.Forms.Button()
        Me.btnAgregaAudio = New System.Windows.Forms.Button()
        Me.btnReestablecePresentador = New System.Windows.Forms.Button()
        Me.btnIniciaPresentador = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnPDFZoomIn = New System.Windows.Forms.Button()
        Me.btnPDFZoomOut = New System.Windows.Forms.Button()
        Me.btnPDFUltimo = New System.Windows.Forms.Button()
        Me.btnPDFSiguiente = New System.Windows.Forms.Button()
        Me.btnPDFAnterior = New System.Windows.Forms.Button()
        Me.btnPDFPrimero = New System.Windows.Forms.Button()
        Me.btnVideoFullscreen = New System.Windows.Forms.Button()
        Me.btnVideoMute = New System.Windows.Forms.Button()
        Me.btnVideoPlayPausa = New System.Windows.Forms.Button()
        Me.btnAudioMute = New System.Windows.Forms.Button()
        Me.btnAudioPlayPausa = New System.Windows.Forms.Button()
        Me.btnImagenPosicion = New System.Windows.Forms.Button()
        Me.btnImagenLuz = New System.Windows.Forms.Button()
        Me.btnGrabarCompartir = New System.Windows.Forms.Button()
        Me.btnGrabarToogle = New System.Windows.Forms.Button()
        Me.btnBuscaCarpetaGrabaciones = New System.Windows.Forms.Button()
        Me.lblUbicacionGrabaciones = New System.Windows.Forms.Label()
        Me.lblAudioPosition = New System.Windows.Forms.Label()
        Me.lblVideoPosition = New System.Windows.Forms.Label()
        Me.btnBug = New System.Windows.Forms.Button()
        Me.btnGrabarDetener = New System.Windows.Forms.Button()
        Me.chkGrabacionInteligente = New System.Windows.Forms.CheckBox()
        Me.btnCancionCancelar = New System.Windows.Forms.Button()
        Me.btnCancelarCita = New System.Windows.Forms.Button()
        Me.trackAudioPosition = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlCanciones = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCitas = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelControlPDF = New System.Windows.Forms.Panel()
        Me.panelControlAudio = New System.Windows.Forms.Panel()
        Me.panelControlVideo = New System.Windows.Forms.Panel()
        Me.trackVideoPosicionActual = New System.Windows.Forms.TrackBar()
        Me.lblNombreArchivo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.panConfigs = New System.Windows.Forms.Panel()
        Me.chkMelodias = New System.Windows.Forms.CheckBox()
        Me.cmbIdioma = New System.Windows.Forms.ComboBox()
        Me.lblIdioma = New System.Windows.Forms.Label()
        Me.txtCarpetaGrabaciones = New System.Windows.Forms.TextBox()
        Me.txtPatronDespuesCanciones = New System.Windows.Forms.TextBox()
        Me.txtPatronAntesCanciones = New System.Windows.Forms.TextBox()
        Me.txtCarpetaCanciones = New System.Windows.Forms.TextBox()
        Me.txtBackgroudImage = New System.Windows.Forms.TextBox()
        Me.txtURLBroadcasting = New System.Windows.Forms.TextBox()
        Me.txtURLWOL = New System.Windows.Forms.TextBox()
        Me.txtSitioOficial = New System.Windows.Forms.TextBox()
        Me.txtURLBuscador = New System.Windows.Forms.TextBox()
        Me.txtFormatoAudio = New System.Windows.Forms.TextBox()
        Me.txtFormatoVideos = New System.Windows.Forms.TextBox()
        Me.txtFormatoImagenes = New System.Windows.Forms.TextBox()
        Me.lblConfiguracion = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelControlImagen = New System.Windows.Forms.Panel()
        Me.PanelDeGrabacion = New System.Windows.Forms.Panel()
        Me.lblGrabarFilename = New System.Windows.Forms.Label()
        Me.lblGrabarStatus = New System.Windows.Forms.Label()
        Me.timAudioPosicionActual = New System.Windows.Forms.Timer(Me.components)
        Me.timVideoPosicionActual = New System.Windows.Forms.Timer(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.ToolTipDestination = New System.Windows.Forms.ToolStripStatusLabel()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnReacomodar = New System.Windows.Forms.Button()
        CType(Me.numCanciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackPDFZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackVideoVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trackAudioPosition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCanciones.SuspendLayout()
        Me.pnlCitas.SuspendLayout()
        Me.panelControlPDF.SuspendLayout()
        Me.panelControlAudio.SuspendLayout()
        Me.panelControlVideo.SuspendLayout()
        CType(Me.trackVideoPosicionActual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panConfigs.SuspendLayout()
        Me.panelControlImagen.SuspendLayout()
        Me.PanelDeGrabacion.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblStatus.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblStatus.Location = New System.Drawing.Point(526, 67)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(345, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Presentación nunca ha sido abierta durante esta ejecución."
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstContenidos
        '
        Me.lstContenidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstContenidos.BackColor = System.Drawing.Color.Gray
        Me.lstContenidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstContenidos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmTipo, Me.clmFile})
        Me.lstContenidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstContenidos.ForeColor = System.Drawing.SystemColors.Info
        Me.lstContenidos.FullRowSelect = True
        Me.lstContenidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstContenidos.HideSelection = False
        Me.lstContenidos.Location = New System.Drawing.Point(526, 217)
        Me.lstContenidos.MultiSelect = False
        Me.lstContenidos.Name = "lstContenidos"
        Me.lstContenidos.ShowItemToolTips = True
        Me.lstContenidos.Size = New System.Drawing.Size(840, 450)
        Me.lstContenidos.TabIndex = 43
        Me.lstContenidos.UseCompatibleStateImageBehavior = False
        Me.lstContenidos.View = System.Windows.Forms.View.Details
        '
        'clmTipo
        '
        Me.clmTipo.Text = "Tipo"
        Me.clmTipo.Width = 162
        '
        'clmFile
        '
        Me.clmFile.Text = "Ubicación de contenido"
        Me.clmFile.Width = 558
        '
        'numCanciones
        '
        Me.numCanciones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCanciones.Location = New System.Drawing.Point(280, 12)
        Me.numCanciones.Maximum = New Decimal(New Integer() {142, 0, 0, 0})
        Me.numCanciones.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCanciones.Name = "numCanciones"
        Me.numCanciones.Size = New System.Drawing.Size(74, 21)
        Me.numCanciones.TabIndex = 17
        Me.numCanciones.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'trackPDFZoom
        '
        Me.trackPDFZoom.AutoSize = False
        Me.trackPDFZoom.BackColor = System.Drawing.Color.SeaGreen
        Me.trackPDFZoom.Location = New System.Drawing.Point(279, 0)
        Me.trackPDFZoom.Maximum = 200
        Me.trackPDFZoom.Name = "trackPDFZoom"
        Me.trackPDFZoom.Size = New System.Drawing.Size(207, 50)
        Me.trackPDFZoom.TabIndex = 26
        Me.trackPDFZoom.TickFrequency = 20
        Me.trackPDFZoom.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.trackPDFZoom.Value = 100
        '
        'TrackBar1
        '
        Me.TrackBar1.AutoSize = False
        Me.TrackBar1.BackColor = System.Drawing.Color.Coral
        Me.TrackBar1.Location = New System.Drawing.Point(111, 0)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(107, 50)
        Me.TrackBar1.TabIndex = 34
        Me.TrackBar1.TickFrequency = 10
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.TrackBar1.Value = 100
        '
        'trackVideoVolume
        '
        Me.trackVideoVolume.AutoSize = False
        Me.trackVideoVolume.BackColor = System.Drawing.Color.Teal
        Me.trackVideoVolume.Location = New System.Drawing.Point(111, 0)
        Me.trackVideoVolume.Maximum = 100
        Me.trackVideoVolume.Name = "trackVideoVolume"
        Me.trackVideoVolume.Size = New System.Drawing.Size(107, 50)
        Me.trackVideoVolume.TabIndex = 30
        Me.trackVideoVolume.TickFrequency = 10
        Me.trackVideoVolume.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.trackVideoVolume.Value = 100
        '
        'chkAgregaAutomaticamente
        '
        Me.chkAgregaAutomaticamente.AutoSize = True
        Me.chkAgregaAutomaticamente.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAgregaAutomaticamente.ForeColor = System.Drawing.Color.White
        Me.chkAgregaAutomaticamente.Location = New System.Drawing.Point(18, 264)
        Me.chkAgregaAutomaticamente.Name = "chkAgregaAutomaticamente"
        Me.chkAgregaAutomaticamente.Size = New System.Drawing.Size(472, 22)
        Me.chkAgregaAutomaticamente.TabIndex = 16
        Me.chkAgregaAutomaticamente.Text = "Mostrar o reproducir el contenido en cuanto se agrega"
        Me.chkAgregaAutomaticamente.UseVisualStyleBackColor = True
        '
        'btnAbreJWorg
        '
        Me.btnAbreJWorg.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbreJWorg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAbreJWorg.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAbreJWorg.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAbreJWorg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreJWorg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreJWorg.ForeColor = System.Drawing.Color.White
        Me.btnAbreJWorg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbreJWorg.Location = New System.Drawing.Point(16, 195)
        Me.btnAbreJWorg.Name = "btnAbreJWorg"
        Me.btnAbreJWorg.Size = New System.Drawing.Size(155, 63)
        Me.btnAbreJWorg.TabIndex = 13
        Me.btnAbreJWorg.Text = "Sitio Oficial *"
        Me.btnAbreJWorg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbreJWorg.UseVisualStyleBackColor = False
        '
        'btnAbreWOL
        '
        Me.btnAbreWOL.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbreWOL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAbreWOL.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAbreWOL.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAbreWOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreWOL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreWOL.ForeColor = System.Drawing.Color.White
        Me.btnAbreWOL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbreWOL.Location = New System.Drawing.Point(177, 195)
        Me.btnAbreWOL.Name = "btnAbreWOL"
        Me.btnAbreWOL.Size = New System.Drawing.Size(155, 63)
        Me.btnAbreWOL.TabIndex = 14
        Me.btnAbreWOL.Text = "Biblioteca en Línea *"
        Me.btnAbreWOL.UseVisualStyleBackColor = False
        '
        'btnAbreTV
        '
        Me.btnAbreTV.BackColor = System.Drawing.Color.SteelBlue
        Me.btnAbreTV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAbreTV.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAbreTV.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAbreTV.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreTV.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreTV.ForeColor = System.Drawing.Color.White
        Me.btnAbreTV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbreTV.Location = New System.Drawing.Point(338, 195)
        Me.btnAbreTV.Name = "btnAbreTV"
        Me.btnAbreTV.Size = New System.Drawing.Size(155, 63)
        Me.btnAbreTV.TabIndex = 15
        Me.btnAbreTV.Text = "Broadcasting *"
        Me.btnAbreTV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbreTV.UseVisualStyleBackColor = False
        '
        'btnAgregarCancionLista
        '
        Me.btnAgregarCancionLista.BackColor = System.Drawing.Color.Coral
        Me.btnAgregarCancionLista.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnAgregarCancionLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarCancionLista.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCancionLista.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCancionLista.Location = New System.Drawing.Point(360, 9)
        Me.btnAgregarCancionLista.Name = "btnAgregarCancionLista"
        Me.btnAgregarCancionLista.Size = New System.Drawing.Size(79, 23)
        Me.btnAgregarCancionLista.TabIndex = 18
        Me.btnAgregarCancionLista.Text = "Agregar"
        Me.btnAgregarCancionLista.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(55, 11)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(299, 21)
        Me.ComboBox1.TabIndex = 19
        '
        'btnAgregaCitaLista
        '
        Me.btnAgregaCitaLista.BackColor = System.Drawing.Color.Silver
        Me.btnAgregaCitaLista.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAgregaCitaLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaCitaLista.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaCitaLista.ForeColor = System.Drawing.Color.Black
        Me.btnAgregaCitaLista.Location = New System.Drawing.Point(360, 9)
        Me.btnAgregaCitaLista.Name = "btnAgregaCitaLista"
        Me.btnAgregaCitaLista.Size = New System.Drawing.Size(79, 23)
        Me.btnAgregaCitaLista.TabIndex = 20
        Me.btnAgregaCitaLista.Text = "Agregar"
        Me.btnAgregaCitaLista.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(5, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Imagenes:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label8.Location = New System.Drawing.Point(5, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Videos:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Location = New System.Drawing.Point(5, 88)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(139, 13)
        Me.Label9.TabIndex = 83
        Me.Label9.Text = "Audio:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Location = New System.Drawing.Point(5, 114)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(139, 13)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "URL Buscador:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Location = New System.Drawing.Point(5, 140)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Sitio oficial:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label12.Location = New System.Drawing.Point(5, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(139, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Sitio WOL:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Location = New System.Drawing.Point(5, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Broadcasting:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(5, 218)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(139, 13)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Fondo de pantalla:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.Location = New System.Drawing.Point(5, 270)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 13)
        Me.Label15.TabIndex = 86
        Me.Label15.Text = "Ubicación canciones:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label16.Location = New System.Drawing.Point(5, 296)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(139, 13)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Nombre canciones:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAbreURLBuscador
        '
        Me.btnAbreURLBuscador.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreURLBuscador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreURLBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreURLBuscador.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreURLBuscador.ForeColor = System.Drawing.Color.White
        Me.btnAbreURLBuscador.Location = New System.Drawing.Point(384, 111)
        Me.btnAbreURLBuscador.Name = "btnAbreURLBuscador"
        Me.btnAbreURLBuscador.Size = New System.Drawing.Size(34, 23)
        Me.btnAbreURLBuscador.TabIndex = 46
        Me.btnAbreURLBuscador.Text = "Ir"
        Me.btnAbreURLBuscador.UseVisualStyleBackColor = False
        '
        'btnAbreSitioOficialTest
        '
        Me.btnAbreSitioOficialTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreSitioOficialTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreSitioOficialTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreSitioOficialTest.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreSitioOficialTest.ForeColor = System.Drawing.Color.White
        Me.btnAbreSitioOficialTest.Location = New System.Drawing.Point(384, 137)
        Me.btnAbreSitioOficialTest.Name = "btnAbreSitioOficialTest"
        Me.btnAbreSitioOficialTest.Size = New System.Drawing.Size(34, 23)
        Me.btnAbreSitioOficialTest.TabIndex = 88
        Me.btnAbreSitioOficialTest.Text = "Ir"
        Me.btnAbreSitioOficialTest.UseVisualStyleBackColor = False
        '
        'btnAbreWOLTest
        '
        Me.btnAbreWOLTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreWOLTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreWOLTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreWOLTest.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreWOLTest.ForeColor = System.Drawing.Color.White
        Me.btnAbreWOLTest.Location = New System.Drawing.Point(384, 163)
        Me.btnAbreWOLTest.Name = "btnAbreWOLTest"
        Me.btnAbreWOLTest.Size = New System.Drawing.Size(34, 23)
        Me.btnAbreWOLTest.TabIndex = 89
        Me.btnAbreWOLTest.Text = "Ir"
        Me.btnAbreWOLTest.UseVisualStyleBackColor = False
        '
        'btnAbreBroadcastingTest
        '
        Me.btnAbreBroadcastingTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreBroadcastingTest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbreBroadcastingTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbreBroadcastingTest.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbreBroadcastingTest.ForeColor = System.Drawing.Color.White
        Me.btnAbreBroadcastingTest.Location = New System.Drawing.Point(384, 189)
        Me.btnAbreBroadcastingTest.Name = "btnAbreBroadcastingTest"
        Me.btnAbreBroadcastingTest.Size = New System.Drawing.Size(34, 23)
        Me.btnAbreBroadcastingTest.TabIndex = 90
        Me.btnAbreBroadcastingTest.Text = "Ir"
        Me.btnAbreBroadcastingTest.UseVisualStyleBackColor = False
        '
        'btnBuscaImagenFondo
        '
        Me.btnBuscaImagenFondo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscaImagenFondo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscaImagenFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaImagenFondo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaImagenFondo.ForeColor = System.Drawing.Color.White
        Me.btnBuscaImagenFondo.Location = New System.Drawing.Point(384, 215)
        Me.btnBuscaImagenFondo.Name = "btnBuscaImagenFondo"
        Me.btnBuscaImagenFondo.Size = New System.Drawing.Size(34, 23)
        Me.btnBuscaImagenFondo.TabIndex = 91
        Me.btnBuscaImagenFondo.Text = "..."
        Me.btnBuscaImagenFondo.UseVisualStyleBackColor = False
        '
        'btnBuscaCarpetaCanciones
        '
        Me.btnBuscaCarpetaCanciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscaCarpetaCanciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscaCarpetaCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaCarpetaCanciones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCarpetaCanciones.ForeColor = System.Drawing.Color.White
        Me.btnBuscaCarpetaCanciones.Location = New System.Drawing.Point(384, 267)
        Me.btnBuscaCarpetaCanciones.Name = "btnBuscaCarpetaCanciones"
        Me.btnBuscaCarpetaCanciones.Size = New System.Drawing.Size(34, 23)
        Me.btnBuscaCarpetaCanciones.TabIndex = 92
        Me.btnBuscaCarpetaCanciones.Text = "..."
        Me.btnBuscaCarpetaCanciones.UseVisualStyleBackColor = False
        '
        'btnCancelarConfig
        '
        Me.btnCancelarConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCancelarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarConfig.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarConfig.ForeColor = System.Drawing.Color.White
        Me.btnCancelarConfig.Location = New System.Drawing.Point(308, 368)
        Me.btnCancelarConfig.Name = "btnCancelarConfig"
        Me.btnCancelarConfig.Size = New System.Drawing.Size(110, 23)
        Me.btnCancelarConfig.TabIndex = 46
        Me.btnCancelarConfig.Text = "Cancelar"
        Me.btnCancelarConfig.UseVisualStyleBackColor = False
        '
        'btnGuardarConfig
        '
        Me.btnGuardarConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardarConfig.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardarConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarConfig.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarConfig.ForeColor = System.Drawing.Color.White
        Me.btnGuardarConfig.Location = New System.Drawing.Point(193, 368)
        Me.btnGuardarConfig.Name = "btnGuardarConfig"
        Me.btnGuardarConfig.Size = New System.Drawing.Size(110, 23)
        Me.btnGuardarConfig.TabIndex = 93
        Me.btnGuardarConfig.Text = "Guardar"
        Me.btnGuardarConfig.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Location = New System.Drawing.Point(249, 296)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 13)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "(Número de canción)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnReestablecer
        '
        Me.btnReestablecer.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReestablecer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReestablecer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReestablecer.ForeColor = System.Drawing.Color.White
        Me.btnReestablecer.Location = New System.Drawing.Point(19, 368)
        Me.btnReestablecer.Name = "btnReestablecer"
        Me.btnReestablecer.Size = New System.Drawing.Size(110, 23)
        Me.btnReestablecer.TabIndex = 96
        Me.btnReestablecer.Text = "Restablecer"
        Me.btnReestablecer.UseVisualStyleBackColor = False
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConfiguracion.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnConfiguracion.BackgroundImage = Global.Presentador.My.Resources.Resources.Configuracion
        Me.btnConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnConfiguracion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfiguracion.Location = New System.Drawing.Point(1166, 0)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(50, 25)
        Me.btnConfiguracion.TabIndex = 4
        Me.btnConfiguracion.UseVisualStyleBackColor = False
        '
        'btnCerrarArchivo
        '
        Me.btnCerrarArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrarArchivo.BackgroundImage = Global.Presentador.My.Resources.Resources.Cerrar1
        Me.btnCerrarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrarArchivo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCerrarArchivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCerrarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarArchivo.Location = New System.Drawing.Point(638, 161)
        Me.btnCerrarArchivo.Name = "btnCerrarArchivo"
        Me.btnCerrarArchivo.Size = New System.Drawing.Size(50, 50)
        Me.btnCerrarArchivo.TabIndex = 37
        Me.btnCerrarArchivo.UseVisualStyleBackColor = False
        '
        'btnLimpiaItem
        '
        Me.btnLimpiaItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiaItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiaItem.BackgroundImage = Global.Presentador.My.Resources.Resources.Eliminar
        Me.btnLimpiaItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiaItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLimpiaItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiaItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiaItem.Location = New System.Drawing.Point(1204, 161)
        Me.btnLimpiaItem.Name = "btnLimpiaItem"
        Me.btnLimpiaItem.Size = New System.Drawing.Size(50, 50)
        Me.btnLimpiaItem.TabIndex = 40
        Me.btnLimpiaItem.UseVisualStyleBackColor = False
        '
        'btnValidarContenido
        '
        Me.btnValidarContenido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnValidarContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnValidarContenido.BackgroundImage = Global.Presentador.My.Resources.Resources.ValidarTodo
        Me.btnValidarContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidarContenido.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnValidarContenido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnValidarContenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidarContenido.Location = New System.Drawing.Point(1316, 161)
        Me.btnValidarContenido.Name = "btnValidarContenido"
        Me.btnValidarContenido.Size = New System.Drawing.Size(50, 50)
        Me.btnValidarContenido.TabIndex = 42
        Me.btnValidarContenido.UseVisualStyleBackColor = False
        '
        'btnBajarItem
        '
        Me.btnBajarItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBajarItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBajarItem.BackgroundImage = Global.Presentador.My.Resources.Resources.FlechaAbajo
        Me.btnBajarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBajarItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBajarItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBajarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBajarItem.Location = New System.Drawing.Point(1148, 161)
        Me.btnBajarItem.Name = "btnBajarItem"
        Me.btnBajarItem.Size = New System.Drawing.Size(50, 50)
        Me.btnBajarItem.TabIndex = 39
        Me.btnBajarItem.UseVisualStyleBackColor = False
        '
        'btnAbrirContenidos
        '
        Me.btnAbrirContenidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbrirContenidos.BackgroundImage = Global.Presentador.My.Resources.Resources.Abrir
        Me.btnAbrirContenidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAbrirContenidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAbrirContenidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAbrirContenidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbrirContenidos.Location = New System.Drawing.Point(526, 161)
        Me.btnAbrirContenidos.Name = "btnAbrirContenidos"
        Me.btnAbrirContenidos.Size = New System.Drawing.Size(50, 50)
        Me.btnAbrirContenidos.TabIndex = 35
        Me.btnAbrirContenidos.UseVisualStyleBackColor = False
        '
        'btnGuardarContenidos
        '
        Me.btnGuardarContenidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardarContenidos.BackgroundImage = Global.Presentador.My.Resources.Resources.Guardar
        Me.btnGuardarContenidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarContenidos.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGuardarContenidos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardarContenidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarContenidos.Location = New System.Drawing.Point(582, 161)
        Me.btnGuardarContenidos.Name = "btnGuardarContenidos"
        Me.btnGuardarContenidos.Size = New System.Drawing.Size(50, 50)
        Me.btnGuardarContenidos.TabIndex = 36
        Me.btnGuardarContenidos.UseVisualStyleBackColor = False
        '
        'btnSubirItem
        '
        Me.btnSubirItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubirItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubirItem.BackgroundImage = Global.Presentador.My.Resources.Resources.FlechaArriba
        Me.btnSubirItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSubirItem.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSubirItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSubirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubirItem.Location = New System.Drawing.Point(1092, 161)
        Me.btnSubirItem.Name = "btnSubirItem"
        Me.btnSubirItem.Size = New System.Drawing.Size(50, 50)
        Me.btnSubirItem.TabIndex = 38
        Me.btnSubirItem.UseVisualStyleBackColor = False
        '
        'btnLimpiarContenido
        '
        Me.btnLimpiarContenido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiarContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiarContenido.BackgroundImage = Global.Presentador.My.Resources.Resources.LimpiarLista
        Me.btnLimpiarContenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiarContenido.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLimpiarContenido.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLimpiarContenido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarContenido.Location = New System.Drawing.Point(1260, 161)
        Me.btnLimpiarContenido.Name = "btnLimpiarContenido"
        Me.btnLimpiarContenido.Size = New System.Drawing.Size(50, 50)
        Me.btnLimpiarContenido.TabIndex = 41
        Me.btnLimpiarContenido.UseVisualStyleBackColor = False
        '
        'btnReestablecePresentadorANegro
        '
        Me.btnReestablecePresentadorANegro.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReestablecePresentadorANegro.BackgroundImage = Global.Presentador.My.Resources.Resources.ReestablecerPresentador
        Me.btnReestablecePresentadorANegro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReestablecePresentadorANegro.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReestablecePresentadorANegro.Enabled = False
        Me.btnReestablecePresentadorANegro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReestablecePresentadorANegro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReestablecePresentadorANegro.Location = New System.Drawing.Point(582, 92)
        Me.btnReestablecePresentadorANegro.Name = "btnReestablecePresentadorANegro"
        Me.btnReestablecePresentadorANegro.Size = New System.Drawing.Size(50, 50)
        Me.btnReestablecePresentadorANegro.TabIndex = 1
        Me.btnReestablecePresentadorANegro.UseVisualStyleBackColor = False
        '
        'btnAgregaCita
        '
        Me.btnAgregaCita.BackColor = System.Drawing.Color.DarkGray
        Me.btnAgregaCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregaCita.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregaCita.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregaCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaCita.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaCita.ForeColor = System.Drawing.Color.White
        Me.btnAgregaCita.Image = Global.Presentador.My.Resources.Resources.AgregarVersiculo
        Me.btnAgregaCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaCita.Location = New System.Drawing.Point(338, 126)
        Me.btnAgregaCita.Name = "btnAgregaCita"
        Me.btnAgregaCita.Size = New System.Drawing.Size(155, 63)
        Me.btnAgregaCita.TabIndex = 12
        Me.btnAgregaCita.Text = "Cita Bíblica *"
        Me.btnAgregaCita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregaCita.UseVisualStyleBackColor = False
        '
        'btnAgregaPDF
        '
        Me.btnAgregaPDF.BackColor = System.Drawing.Color.SeaGreen
        Me.btnAgregaPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregaPDF.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregaPDF.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnAgregaPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaPDF.ForeColor = System.Drawing.Color.White
        Me.btnAgregaPDF.Image = Global.Presentador.My.Resources.Resources.PDF
        Me.btnAgregaPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaPDF.Location = New System.Drawing.Point(338, 57)
        Me.btnAgregaPDF.Name = "btnAgregaPDF"
        Me.btnAgregaPDF.Size = New System.Drawing.Size(155, 63)
        Me.btnAgregaPDF.TabIndex = 9
        Me.btnAgregaPDF.Text = "Archivos PDF"
        Me.btnAgregaPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregaPDF.UseVisualStyleBackColor = False
        '
        'btnAgregaCancion
        '
        Me.btnAgregaCancion.BackColor = System.Drawing.Color.Coral
        Me.btnAgregaCancion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregaCancion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregaCancion.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnAgregaCancion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaCancion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaCancion.ForeColor = System.Drawing.Color.White
        Me.btnAgregaCancion.Image = Global.Presentador.My.Resources.Resources.AgregarCancion
        Me.btnAgregaCancion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaCancion.Location = New System.Drawing.Point(16, 57)
        Me.btnAgregaCancion.Name = "btnAgregaCancion"
        Me.btnAgregaCancion.Size = New System.Drawing.Size(155, 63)
        Me.btnAgregaCancion.TabIndex = 7
        Me.btnAgregaCancion.Text = "Canciones"
        Me.btnAgregaCancion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregaCancion.UseVisualStyleBackColor = False
        '
        'btnAgregaVideo
        '
        Me.btnAgregaVideo.BackColor = System.Drawing.Color.Teal
        Me.btnAgregaVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregaVideo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregaVideo.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnAgregaVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaVideo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaVideo.ForeColor = System.Drawing.Color.White
        Me.btnAgregaVideo.Image = Global.Presentador.My.Resources.Resources.AgregarVideo
        Me.btnAgregaVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaVideo.Location = New System.Drawing.Point(177, 57)
        Me.btnAgregaVideo.Name = "btnAgregaVideo"
        Me.btnAgregaVideo.Size = New System.Drawing.Size(155, 63)
        Me.btnAgregaVideo.TabIndex = 8
        Me.btnAgregaVideo.Text = "Videos"
        Me.btnAgregaVideo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregaVideo.UseVisualStyleBackColor = False
        '
        'btnAgregaImagen
        '
        Me.btnAgregaImagen.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnAgregaImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregaImagen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregaImagen.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue
        Me.btnAgregaImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaImagen.ForeColor = System.Drawing.Color.White
        Me.btnAgregaImagen.Image = Global.Presentador.My.Resources.Resources.AgregarImagenes
        Me.btnAgregaImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaImagen.Location = New System.Drawing.Point(16, 126)
        Me.btnAgregaImagen.Name = "btnAgregaImagen"
        Me.btnAgregaImagen.Size = New System.Drawing.Size(155, 63)
        Me.btnAgregaImagen.TabIndex = 10
        Me.btnAgregaImagen.Text = "Imágenes"
        Me.btnAgregaImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregaImagen.UseVisualStyleBackColor = False
        '
        'btnAgregaAudio
        '
        Me.btnAgregaAudio.BackColor = System.Drawing.Color.Coral
        Me.btnAgregaAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregaAudio.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAgregaAudio.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnAgregaAudio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregaAudio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregaAudio.ForeColor = System.Drawing.Color.White
        Me.btnAgregaAudio.Image = Global.Presentador.My.Resources.Resources.AgregarMusica
        Me.btnAgregaAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregaAudio.Location = New System.Drawing.Point(177, 126)
        Me.btnAgregaAudio.Name = "btnAgregaAudio"
        Me.btnAgregaAudio.Size = New System.Drawing.Size(155, 63)
        Me.btnAgregaAudio.TabIndex = 11
        Me.btnAgregaAudio.Text = "Archivos de Audio"
        Me.btnAgregaAudio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgregaAudio.UseVisualStyleBackColor = False
        '
        'btnReestablecePresentador
        '
        Me.btnReestablecePresentador.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReestablecePresentador.BackgroundImage = Global.Presentador.My.Resources.Resources.ReestablecerPresentador
        Me.btnReestablecePresentador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReestablecePresentador.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReestablecePresentador.Enabled = False
        Me.btnReestablecePresentador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnReestablecePresentador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReestablecePresentador.Location = New System.Drawing.Point(638, 92)
        Me.btnReestablecePresentador.Name = "btnReestablecePresentador"
        Me.btnReestablecePresentador.Size = New System.Drawing.Size(50, 50)
        Me.btnReestablecePresentador.TabIndex = 2
        Me.btnReestablecePresentador.UseVisualStyleBackColor = False
        '
        'btnIniciaPresentador
        '
        Me.btnIniciaPresentador.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIniciaPresentador.BackgroundImage = CType(resources.GetObject("btnIniciaPresentador.BackgroundImage"), System.Drawing.Image)
        Me.btnIniciaPresentador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIniciaPresentador.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnIniciaPresentador.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIniciaPresentador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciaPresentador.Location = New System.Drawing.Point(526, 92)
        Me.btnIniciaPresentador.Name = "btnIniciaPresentador"
        Me.btnIniciaPresentador.Size = New System.Drawing.Size(50, 50)
        Me.btnIniciaPresentador.TabIndex = 3
        Me.btnIniciaPresentador.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMinimizar.BackgroundImage = Global.Presentador.My.Resources.Resources.FlechaAbajo
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(1216, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(50, 25)
        Me.btnMinimizar.TabIndex = 5
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCerrar.BackgroundImage = Global.Presentador.My.Resources.Resources.Cerrar
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1328, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(50, 25)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnPDFZoomIn
        '
        Me.btnPDFZoomIn.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPDFZoomIn.BackgroundImage = Global.Presentador.My.Resources.Resources.ZoomIn
        Me.btnPDFZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDFZoomIn.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPDFZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnPDFZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFZoomIn.Location = New System.Drawing.Point(492, 0)
        Me.btnPDFZoomIn.Name = "btnPDFZoomIn"
        Me.btnPDFZoomIn.Size = New System.Drawing.Size(50, 50)
        Me.btnPDFZoomIn.TabIndex = 27
        Me.btnPDFZoomIn.UseVisualStyleBackColor = False
        '
        'btnPDFZoomOut
        '
        Me.btnPDFZoomOut.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPDFZoomOut.BackgroundImage = Global.Presentador.My.Resources.Resources.ZoomOut
        Me.btnPDFZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDFZoomOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPDFZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnPDFZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFZoomOut.Location = New System.Drawing.Point(224, 0)
        Me.btnPDFZoomOut.Name = "btnPDFZoomOut"
        Me.btnPDFZoomOut.Size = New System.Drawing.Size(50, 50)
        Me.btnPDFZoomOut.TabIndex = 25
        Me.btnPDFZoomOut.UseVisualStyleBackColor = False
        '
        'btnPDFUltimo
        '
        Me.btnPDFUltimo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPDFUltimo.BackgroundImage = Global.Presentador.My.Resources.Resources.Ultimo
        Me.btnPDFUltimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDFUltimo.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPDFUltimo.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnPDFUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFUltimo.Location = New System.Drawing.Point(168, 0)
        Me.btnPDFUltimo.Name = "btnPDFUltimo"
        Me.btnPDFUltimo.Size = New System.Drawing.Size(50, 50)
        Me.btnPDFUltimo.TabIndex = 24
        Me.btnPDFUltimo.UseVisualStyleBackColor = False
        '
        'btnPDFSiguiente
        '
        Me.btnPDFSiguiente.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPDFSiguiente.BackgroundImage = Global.Presentador.My.Resources.Resources.Play
        Me.btnPDFSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDFSiguiente.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPDFSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnPDFSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFSiguiente.Location = New System.Drawing.Point(112, 0)
        Me.btnPDFSiguiente.Name = "btnPDFSiguiente"
        Me.btnPDFSiguiente.Size = New System.Drawing.Size(50, 50)
        Me.btnPDFSiguiente.TabIndex = 23
        Me.btnPDFSiguiente.UseVisualStyleBackColor = False
        '
        'btnPDFAnterior
        '
        Me.btnPDFAnterior.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPDFAnterior.BackgroundImage = Global.Presentador.My.Resources.Resources.Anterior
        Me.btnPDFAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDFAnterior.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPDFAnterior.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnPDFAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFAnterior.Location = New System.Drawing.Point(56, 0)
        Me.btnPDFAnterior.Name = "btnPDFAnterior"
        Me.btnPDFAnterior.Size = New System.Drawing.Size(50, 50)
        Me.btnPDFAnterior.TabIndex = 22
        Me.btnPDFAnterior.UseVisualStyleBackColor = False
        '
        'btnPDFPrimero
        '
        Me.btnPDFPrimero.BackColor = System.Drawing.Color.SeaGreen
        Me.btnPDFPrimero.BackgroundImage = Global.Presentador.My.Resources.Resources.Primero
        Me.btnPDFPrimero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPDFPrimero.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPDFPrimero.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.btnPDFPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPDFPrimero.Location = New System.Drawing.Point(0, 0)
        Me.btnPDFPrimero.Name = "btnPDFPrimero"
        Me.btnPDFPrimero.Size = New System.Drawing.Size(50, 50)
        Me.btnPDFPrimero.TabIndex = 21
        Me.btnPDFPrimero.UseVisualStyleBackColor = False
        '
        'btnVideoFullscreen
        '
        Me.btnVideoFullscreen.BackColor = System.Drawing.Color.Teal
        Me.btnVideoFullscreen.BackgroundImage = Global.Presentador.My.Resources.Resources.Fullscreen
        Me.btnVideoFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVideoFullscreen.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVideoFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnVideoFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVideoFullscreen.Location = New System.Drawing.Point(224, 0)
        Me.btnVideoFullscreen.Name = "btnVideoFullscreen"
        Me.btnVideoFullscreen.Size = New System.Drawing.Size(50, 50)
        Me.btnVideoFullscreen.TabIndex = 31
        Me.btnVideoFullscreen.UseVisualStyleBackColor = False
        '
        'btnVideoMute
        '
        Me.btnVideoMute.BackColor = System.Drawing.Color.Teal
        Me.btnVideoMute.BackgroundImage = Global.Presentador.My.Resources.Resources.Silencio
        Me.btnVideoMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVideoMute.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVideoMute.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnVideoMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVideoMute.Location = New System.Drawing.Point(56, 0)
        Me.btnVideoMute.Name = "btnVideoMute"
        Me.btnVideoMute.Size = New System.Drawing.Size(50, 50)
        Me.btnVideoMute.TabIndex = 29
        Me.btnVideoMute.UseVisualStyleBackColor = False
        '
        'btnVideoPlayPausa
        '
        Me.btnVideoPlayPausa.BackColor = System.Drawing.Color.Teal
        Me.btnVideoPlayPausa.BackgroundImage = Global.Presentador.My.Resources.Resources.Pausa
        Me.btnVideoPlayPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVideoPlayPausa.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnVideoPlayPausa.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnVideoPlayPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVideoPlayPausa.Location = New System.Drawing.Point(0, 0)
        Me.btnVideoPlayPausa.Name = "btnVideoPlayPausa"
        Me.btnVideoPlayPausa.Size = New System.Drawing.Size(50, 50)
        Me.btnVideoPlayPausa.TabIndex = 28
        Me.btnVideoPlayPausa.UseVisualStyleBackColor = False
        '
        'btnAudioMute
        '
        Me.btnAudioMute.BackColor = System.Drawing.Color.Coral
        Me.btnAudioMute.BackgroundImage = Global.Presentador.My.Resources.Resources.Silencio
        Me.btnAudioMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAudioMute.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAudioMute.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnAudioMute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAudioMute.Location = New System.Drawing.Point(56, 0)
        Me.btnAudioMute.Name = "btnAudioMute"
        Me.btnAudioMute.Size = New System.Drawing.Size(50, 50)
        Me.btnAudioMute.TabIndex = 33
        Me.btnAudioMute.UseVisualStyleBackColor = False
        '
        'btnAudioPlayPausa
        '
        Me.btnAudioPlayPausa.BackColor = System.Drawing.Color.Coral
        Me.btnAudioPlayPausa.BackgroundImage = Global.Presentador.My.Resources.Resources.Pausa
        Me.btnAudioPlayPausa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAudioPlayPausa.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAudioPlayPausa.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnAudioPlayPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAudioPlayPausa.Location = New System.Drawing.Point(0, 0)
        Me.btnAudioPlayPausa.Name = "btnAudioPlayPausa"
        Me.btnAudioPlayPausa.Size = New System.Drawing.Size(50, 50)
        Me.btnAudioPlayPausa.TabIndex = 32
        Me.btnAudioPlayPausa.UseVisualStyleBackColor = False
        '
        'btnImagenPosicion
        '
        Me.btnImagenPosicion.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnImagenPosicion.BackgroundImage = Global.Presentador.My.Resources.Resources.AjustarImagen
        Me.btnImagenPosicion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImagenPosicion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnImagenPosicion.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnImagenPosicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagenPosicion.Location = New System.Drawing.Point(56, 1)
        Me.btnImagenPosicion.Name = "btnImagenPosicion"
        Me.btnImagenPosicion.Size = New System.Drawing.Size(50, 50)
        Me.btnImagenPosicion.TabIndex = 33
        Me.btnImagenPosicion.UseVisualStyleBackColor = False
        '
        'btnImagenLuz
        '
        Me.btnImagenLuz.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnImagenLuz.BackgroundImage = Global.Presentador.My.Resources.Resources.Luz
        Me.btnImagenLuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImagenLuz.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnImagenLuz.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen
        Me.btnImagenLuz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImagenLuz.Location = New System.Drawing.Point(0, 1)
        Me.btnImagenLuz.Name = "btnImagenLuz"
        Me.btnImagenLuz.Size = New System.Drawing.Size(50, 50)
        Me.btnImagenLuz.TabIndex = 32
        Me.btnImagenLuz.UseVisualStyleBackColor = False
        '
        'btnGrabarCompartir
        '
        Me.btnGrabarCompartir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGrabarCompartir.BackgroundImage = Global.Presentador.My.Resources.Resources.Compartir
        Me.btnGrabarCompartir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGrabarCompartir.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGrabarCompartir.Enabled = False
        Me.btnGrabarCompartir.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.btnGrabarCompartir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabarCompartir.Location = New System.Drawing.Point(112, 0)
        Me.btnGrabarCompartir.Name = "btnGrabarCompartir"
        Me.btnGrabarCompartir.Size = New System.Drawing.Size(50, 50)
        Me.btnGrabarCompartir.TabIndex = 33
        Me.btnGrabarCompartir.UseVisualStyleBackColor = False
        '
        'btnGrabarToogle
        '
        Me.btnGrabarToogle.BackColor = System.Drawing.Color.LightCoral
        Me.btnGrabarToogle.BackgroundImage = Global.Presentador.My.Resources.Resources.Grabar
        Me.btnGrabarToogle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGrabarToogle.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGrabarToogle.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.btnGrabarToogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabarToogle.Location = New System.Drawing.Point(0, 0)
        Me.btnGrabarToogle.Name = "btnGrabarToogle"
        Me.btnGrabarToogle.Size = New System.Drawing.Size(50, 50)
        Me.btnGrabarToogle.TabIndex = 32
        Me.btnGrabarToogle.UseVisualStyleBackColor = False
        '
        'btnBuscaCarpetaGrabaciones
        '
        Me.btnBuscaCarpetaGrabaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscaCarpetaGrabaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscaCarpetaGrabaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscaCarpetaGrabaciones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscaCarpetaGrabaciones.ForeColor = System.Drawing.Color.White
        Me.btnBuscaCarpetaGrabaciones.Location = New System.Drawing.Point(384, 241)
        Me.btnBuscaCarpetaGrabaciones.Name = "btnBuscaCarpetaGrabaciones"
        Me.btnBuscaCarpetaGrabaciones.Size = New System.Drawing.Size(34, 23)
        Me.btnBuscaCarpetaGrabaciones.TabIndex = 99
        Me.btnBuscaCarpetaGrabaciones.Text = "..."
        Me.btnBuscaCarpetaGrabaciones.UseVisualStyleBackColor = False
        '
        'lblUbicacionGrabaciones
        '
        Me.lblUbicacionGrabaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUbicacionGrabaciones.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacionGrabaciones.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblUbicacionGrabaciones.Location = New System.Drawing.Point(5, 244)
        Me.lblUbicacionGrabaciones.Name = "lblUbicacionGrabaciones"
        Me.lblUbicacionGrabaciones.Size = New System.Drawing.Size(139, 13)
        Me.lblUbicacionGrabaciones.TabIndex = 98
        Me.lblUbicacionGrabaciones.Text = "Ubicación grabaciones:"
        Me.lblUbicacionGrabaciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblAudioPosition
        '
        Me.lblAudioPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAudioPosition.AutoSize = True
        Me.lblAudioPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAudioPosition.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAudioPosition.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblAudioPosition.Location = New System.Drawing.Point(583, 50)
        Me.lblAudioPosition.Name = "lblAudioPosition"
        Me.lblAudioPosition.Size = New System.Drawing.Size(86, 13)
        Me.lblAudioPosition.TabIndex = 36
        Me.lblAudioPosition.Text = "00:00 / 00:00"
        Me.lblAudioPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVideoPosition
        '
        Me.lblVideoPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVideoPosition.AutoSize = True
        Me.lblVideoPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblVideoPosition.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVideoPosition.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblVideoPosition.Location = New System.Drawing.Point(583, 50)
        Me.lblVideoPosition.Name = "lblVideoPosition"
        Me.lblVideoPosition.Size = New System.Drawing.Size(86, 13)
        Me.lblVideoPosition.TabIndex = 37
        Me.lblVideoPosition.Text = "00:00 / 00:00"
        Me.lblVideoPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBug
        '
        Me.btnBug.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBug.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBug.BackgroundImage = Global.Presentador.My.Resources.Resources.Problema
        Me.btnBug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBug.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnBug.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBug.Location = New System.Drawing.Point(1115, 0)
        Me.btnBug.Name = "btnBug"
        Me.btnBug.Size = New System.Drawing.Size(50, 25)
        Me.btnBug.TabIndex = 73
        Me.btnBug.UseVisualStyleBackColor = False
        '
        'btnGrabarDetener
        '
        Me.btnGrabarDetener.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGrabarDetener.BackgroundImage = Global.Presentador.My.Resources.Resources.Detener
        Me.btnGrabarDetener.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGrabarDetener.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGrabarDetener.Enabled = False
        Me.btnGrabarDetener.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.btnGrabarDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrabarDetener.Location = New System.Drawing.Point(56, 0)
        Me.btnGrabarDetener.Name = "btnGrabarDetener"
        Me.btnGrabarDetener.Size = New System.Drawing.Size(50, 50)
        Me.btnGrabarDetener.TabIndex = 68
        Me.btnGrabarDetener.UseVisualStyleBackColor = False
        '
        'chkGrabacionInteligente
        '
        Me.chkGrabacionInteligente.AutoSize = True
        Me.chkGrabacionInteligente.Checked = True
        Me.chkGrabacionInteligente.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGrabacionInteligente.ForeColor = System.Drawing.Color.White
        Me.chkGrabacionInteligente.Location = New System.Drawing.Point(171, 0)
        Me.chkGrabacionInteligente.Name = "chkGrabacionInteligente"
        Me.chkGrabacionInteligente.Size = New System.Drawing.Size(126, 17)
        Me.chkGrabacionInteligente.TabIndex = 69
        Me.chkGrabacionInteligente.Text = "Grabación inteligente"
        Me.chkGrabacionInteligente.UseVisualStyleBackColor = True
        '
        'btnCancionCancelar
        '
        Me.btnCancionCancelar.BackColor = System.Drawing.Color.Coral
        Me.btnCancionCancelar.BackgroundImage = Global.Presentador.My.Resources.Resources.Cerrar
        Me.btnCancionCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancionCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnCancionCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancionCancelar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancionCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancionCancelar.Location = New System.Drawing.Point(445, 9)
        Me.btnCancionCancelar.Name = "btnCancionCancelar"
        Me.btnCancionCancelar.Size = New System.Drawing.Size(30, 23)
        Me.btnCancionCancelar.TabIndex = 46
        Me.btnCancionCancelar.UseVisualStyleBackColor = False
        '
        'btnCancelarCita
        '
        Me.btnCancelarCita.BackColor = System.Drawing.Color.Silver
        Me.btnCancelarCita.BackgroundImage = Global.Presentador.My.Resources.Resources.Cerrar
        Me.btnCancelarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelarCita.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnCancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCita.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCita.ForeColor = System.Drawing.Color.Black
        Me.btnCancelarCita.Location = New System.Drawing.Point(445, 9)
        Me.btnCancelarCita.Name = "btnCancelarCita"
        Me.btnCancelarCita.Size = New System.Drawing.Size(30, 23)
        Me.btnCancelarCita.TabIndex = 46
        Me.btnCancelarCita.UseVisualStyleBackColor = False
        '
        'trackAudioPosition
        '
        Me.trackAudioPosition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackAudioPosition.AutoSize = False
        Me.trackAudioPosition.BackColor = System.Drawing.Color.Coral
        Me.trackAudioPosition.Location = New System.Drawing.Point(224, 0)
        Me.trackAudioPosition.Maximum = 204
        Me.trackAudioPosition.Name = "trackAudioPosition"
        Me.trackAudioPosition.Size = New System.Drawing.Size(445, 50)
        Me.trackAudioPosition.TabIndex = 35
        Me.trackAudioPosition.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(332, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Agregar a lista de contenido a presentar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(694, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Lista de contenido a presentar"
        '
        'pnlCanciones
        '
        Me.pnlCanciones.Controls.Add(Me.btnCancionCancelar)
        Me.pnlCanciones.Controls.Add(Me.btnAgregarCancionLista)
        Me.pnlCanciones.Controls.Add(Me.numCanciones)
        Me.pnlCanciones.Controls.Add(Me.Label5)
        Me.pnlCanciones.Location = New System.Drawing.Point(12, 309)
        Me.pnlCanciones.Name = "pnlCanciones"
        Me.pnlCanciones.Size = New System.Drawing.Size(478, 42)
        Me.pnlCanciones.TabIndex = 43
        Me.pnlCanciones.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Ingrese el número de la canción:"
        '
        'pnlCitas
        '
        Me.pnlCitas.Controls.Add(Me.btnCancelarCita)
        Me.pnlCitas.Controls.Add(Me.ComboBox1)
        Me.pnlCitas.Controls.Add(Me.btnAgregaCitaLista)
        Me.pnlCitas.Controls.Add(Me.Label6)
        Me.pnlCitas.Location = New System.Drawing.Point(12, 299)
        Me.pnlCitas.Name = "pnlCitas"
        Me.pnlCitas.Size = New System.Drawing.Size(478, 42)
        Me.pnlCitas.TabIndex = 48
        Me.pnlCitas.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Cita:"
        '
        'panelControlPDF
        '
        Me.panelControlPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelControlPDF.Controls.Add(Me.btnPDFZoomIn)
        Me.panelControlPDF.Controls.Add(Me.btnPDFZoomOut)
        Me.panelControlPDF.Controls.Add(Me.trackPDFZoom)
        Me.panelControlPDF.Controls.Add(Me.btnPDFUltimo)
        Me.panelControlPDF.Controls.Add(Me.btnPDFSiguiente)
        Me.panelControlPDF.Controls.Add(Me.btnPDFAnterior)
        Me.panelControlPDF.Controls.Add(Me.btnPDFPrimero)
        Me.panelControlPDF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelControlPDF.Location = New System.Drawing.Point(694, 92)
        Me.panelControlPDF.Name = "panelControlPDF"
        Me.panelControlPDF.Size = New System.Drawing.Size(548, 63)
        Me.panelControlPDF.TabIndex = 49
        Me.panelControlPDF.Visible = False
        '
        'panelControlAudio
        '
        Me.panelControlAudio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelControlAudio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelControlAudio.Controls.Add(Me.lblAudioPosition)
        Me.panelControlAudio.Controls.Add(Me.trackAudioPosition)
        Me.panelControlAudio.Controls.Add(Me.btnAudioMute)
        Me.panelControlAudio.Controls.Add(Me.TrackBar1)
        Me.panelControlAudio.Controls.Add(Me.btnAudioPlayPausa)
        Me.panelControlAudio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelControlAudio.Location = New System.Drawing.Point(694, 92)
        Me.panelControlAudio.Name = "panelControlAudio"
        Me.panelControlAudio.Size = New System.Drawing.Size(672, 63)
        Me.panelControlAudio.TabIndex = 57
        Me.panelControlAudio.Visible = False
        '
        'panelControlVideo
        '
        Me.panelControlVideo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelControlVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelControlVideo.Controls.Add(Me.lblVideoPosition)
        Me.panelControlVideo.Controls.Add(Me.trackVideoPosicionActual)
        Me.panelControlVideo.Controls.Add(Me.btnVideoFullscreen)
        Me.panelControlVideo.Controls.Add(Me.btnVideoMute)
        Me.panelControlVideo.Controls.Add(Me.trackVideoVolume)
        Me.panelControlVideo.Controls.Add(Me.btnVideoPlayPausa)
        Me.panelControlVideo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelControlVideo.Location = New System.Drawing.Point(694, 92)
        Me.panelControlVideo.Name = "panelControlVideo"
        Me.panelControlVideo.Size = New System.Drawing.Size(672, 63)
        Me.panelControlVideo.TabIndex = 58
        Me.panelControlVideo.Visible = False
        '
        'trackVideoPosicionActual
        '
        Me.trackVideoPosicionActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trackVideoPosicionActual.AutoSize = False
        Me.trackVideoPosicionActual.BackColor = System.Drawing.Color.Teal
        Me.trackVideoPosicionActual.Location = New System.Drawing.Point(279, 0)
        Me.trackVideoPosicionActual.Maximum = 100
        Me.trackVideoPosicionActual.Name = "trackVideoPosicionActual"
        Me.trackVideoPosicionActual.Size = New System.Drawing.Size(390, 50)
        Me.trackVideoPosicionActual.TabIndex = 32
        Me.trackVideoPosicionActual.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'lblNombreArchivo
        '
        Me.lblNombreArchivo.AutoSize = True
        Me.lblNombreArchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreArchivo.ForeColor = System.Drawing.Color.White
        Me.lblNombreArchivo.Location = New System.Drawing.Point(694, 191)
        Me.lblNombreArchivo.Name = "lblNombreArchivo"
        Me.lblNombreArchivo.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreArchivo.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(525, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(415, 20)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Control de contenido en Presentación actualmente"
        '
        'panConfigs
        '
        Me.panConfigs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panConfigs.AutoScroll = True
        Me.panConfigs.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panConfigs.Controls.Add(Me.chkMelodias)
        Me.panConfigs.Controls.Add(Me.cmbIdioma)
        Me.panConfigs.Controls.Add(Me.lblIdioma)
        Me.panConfigs.Controls.Add(Me.btnBuscaCarpetaGrabaciones)
        Me.panConfigs.Controls.Add(Me.lblUbicacionGrabaciones)
        Me.panConfigs.Controls.Add(Me.txtCarpetaGrabaciones)
        Me.panConfigs.Controls.Add(Me.btnReestablecer)
        Me.panConfigs.Controls.Add(Me.txtPatronDespuesCanciones)
        Me.panConfigs.Controls.Add(Me.Label17)
        Me.panConfigs.Controls.Add(Me.btnGuardarConfig)
        Me.panConfigs.Controls.Add(Me.btnCancelarConfig)
        Me.panConfigs.Controls.Add(Me.btnBuscaCarpetaCanciones)
        Me.panConfigs.Controls.Add(Me.btnBuscaImagenFondo)
        Me.panConfigs.Controls.Add(Me.btnAbreBroadcastingTest)
        Me.panConfigs.Controls.Add(Me.btnAbreWOLTest)
        Me.panConfigs.Controls.Add(Me.btnAbreSitioOficialTest)
        Me.panConfigs.Controls.Add(Me.btnAbreURLBuscador)
        Me.panConfigs.Controls.Add(Me.Label16)
        Me.panConfigs.Controls.Add(Me.Label15)
        Me.panConfigs.Controls.Add(Me.Label14)
        Me.panConfigs.Controls.Add(Me.Label13)
        Me.panConfigs.Controls.Add(Me.Label12)
        Me.panConfigs.Controls.Add(Me.Label11)
        Me.panConfigs.Controls.Add(Me.Label10)
        Me.panConfigs.Controls.Add(Me.Label9)
        Me.panConfigs.Controls.Add(Me.Label8)
        Me.panConfigs.Controls.Add(Me.Label1)
        Me.panConfigs.Controls.Add(Me.txtPatronAntesCanciones)
        Me.panConfigs.Controls.Add(Me.txtCarpetaCanciones)
        Me.panConfigs.Controls.Add(Me.txtBackgroudImage)
        Me.panConfigs.Controls.Add(Me.txtURLBroadcasting)
        Me.panConfigs.Controls.Add(Me.txtURLWOL)
        Me.panConfigs.Controls.Add(Me.txtSitioOficial)
        Me.panConfigs.Controls.Add(Me.txtURLBuscador)
        Me.panConfigs.Controls.Add(Me.txtFormatoAudio)
        Me.panConfigs.Controls.Add(Me.txtFormatoVideos)
        Me.panConfigs.Controls.Add(Me.txtFormatoImagenes)
        Me.panConfigs.Controls.Add(Me.lblConfiguracion)
        Me.panConfigs.Location = New System.Drawing.Point(12, 356)
        Me.panConfigs.Name = "panConfigs"
        Me.panConfigs.Size = New System.Drawing.Size(480, 399)
        Me.panConfigs.TabIndex = 70
        Me.panConfigs.Visible = False
        '
        'chkMelodias
        '
        Me.chkMelodias.AutoSize = True
        Me.chkMelodias.ForeColor = System.Drawing.Color.White
        Me.chkMelodias.Location = New System.Drawing.Point(149, 319)
        Me.chkMelodias.Name = "chkMelodias"
        Me.chkMelodias.Size = New System.Drawing.Size(81, 17)
        Me.chkMelodias.TabIndex = 102
        Me.chkMelodias.Text = "CheckBox1"
        Me.chkMelodias.UseVisualStyleBackColor = True
        '
        'cmbIdioma
        '
        Me.cmbIdioma.FormattingEnabled = True
        Me.cmbIdioma.Items.AddRange(New Object() {"ES_AR", "EN"})
        Me.cmbIdioma.Location = New System.Drawing.Point(149, 341)
        Me.cmbIdioma.Name = "cmbIdioma"
        Me.cmbIdioma.Size = New System.Drawing.Size(269, 21)
        Me.cmbIdioma.TabIndex = 101
        '
        'lblIdioma
        '
        Me.lblIdioma.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblIdioma.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdioma.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblIdioma.Location = New System.Drawing.Point(5, 344)
        Me.lblIdioma.Name = "lblIdioma"
        Me.lblIdioma.Size = New System.Drawing.Size(139, 13)
        Me.lblIdioma.TabIndex = 100
        Me.lblIdioma.Text = "Idioma:"
        Me.lblIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCarpetaGrabaciones
        '
        Me.txtCarpetaGrabaciones.Location = New System.Drawing.Point(151, 241)
        Me.txtCarpetaGrabaciones.Name = "txtCarpetaGrabaciones"
        Me.txtCarpetaGrabaciones.ReadOnly = True
        Me.txtCarpetaGrabaciones.Size = New System.Drawing.Size(227, 20)
        Me.txtCarpetaGrabaciones.TabIndex = 97
        '
        'txtPatronDespuesCanciones
        '
        Me.txtPatronDespuesCanciones.Location = New System.Drawing.Point(382, 293)
        Me.txtPatronDespuesCanciones.Name = "txtPatronDespuesCanciones"
        Me.txtPatronDespuesCanciones.Size = New System.Drawing.Size(36, 20)
        Me.txtPatronDespuesCanciones.TabIndex = 95
        '
        'txtPatronAntesCanciones
        '
        Me.txtPatronAntesCanciones.Location = New System.Drawing.Point(150, 293)
        Me.txtPatronAntesCanciones.Name = "txtPatronAntesCanciones"
        Me.txtPatronAntesCanciones.Size = New System.Drawing.Size(93, 20)
        Me.txtPatronAntesCanciones.TabIndex = 81
        '
        'txtCarpetaCanciones
        '
        Me.txtCarpetaCanciones.Location = New System.Drawing.Point(151, 267)
        Me.txtCarpetaCanciones.Name = "txtCarpetaCanciones"
        Me.txtCarpetaCanciones.ReadOnly = True
        Me.txtCarpetaCanciones.Size = New System.Drawing.Size(227, 20)
        Me.txtCarpetaCanciones.TabIndex = 80
        '
        'txtBackgroudImage
        '
        Me.txtBackgroudImage.Location = New System.Drawing.Point(151, 215)
        Me.txtBackgroudImage.Name = "txtBackgroudImage"
        Me.txtBackgroudImage.ReadOnly = True
        Me.txtBackgroudImage.Size = New System.Drawing.Size(227, 20)
        Me.txtBackgroudImage.TabIndex = 79
        '
        'txtURLBroadcasting
        '
        Me.txtURLBroadcasting.Location = New System.Drawing.Point(151, 189)
        Me.txtURLBroadcasting.Name = "txtURLBroadcasting"
        Me.txtURLBroadcasting.Size = New System.Drawing.Size(227, 20)
        Me.txtURLBroadcasting.TabIndex = 78
        '
        'txtURLWOL
        '
        Me.txtURLWOL.Location = New System.Drawing.Point(151, 163)
        Me.txtURLWOL.Name = "txtURLWOL"
        Me.txtURLWOL.Size = New System.Drawing.Size(227, 20)
        Me.txtURLWOL.TabIndex = 77
        '
        'txtSitioOficial
        '
        Me.txtSitioOficial.Location = New System.Drawing.Point(150, 137)
        Me.txtSitioOficial.Name = "txtSitioOficial"
        Me.txtSitioOficial.Size = New System.Drawing.Size(228, 20)
        Me.txtSitioOficial.TabIndex = 76
        '
        'txtURLBuscador
        '
        Me.txtURLBuscador.Location = New System.Drawing.Point(151, 111)
        Me.txtURLBuscador.Name = "txtURLBuscador"
        Me.txtURLBuscador.Size = New System.Drawing.Size(227, 20)
        Me.txtURLBuscador.TabIndex = 75
        '
        'txtFormatoAudio
        '
        Me.txtFormatoAudio.Location = New System.Drawing.Point(150, 85)
        Me.txtFormatoAudio.Name = "txtFormatoAudio"
        Me.txtFormatoAudio.Size = New System.Drawing.Size(268, 20)
        Me.txtFormatoAudio.TabIndex = 74
        '
        'txtFormatoVideos
        '
        Me.txtFormatoVideos.Location = New System.Drawing.Point(150, 59)
        Me.txtFormatoVideos.Name = "txtFormatoVideos"
        Me.txtFormatoVideos.Size = New System.Drawing.Size(268, 20)
        Me.txtFormatoVideos.TabIndex = 73
        '
        'txtFormatoImagenes
        '
        Me.txtFormatoImagenes.Location = New System.Drawing.Point(150, 33)
        Me.txtFormatoImagenes.Name = "txtFormatoImagenes"
        Me.txtFormatoImagenes.Size = New System.Drawing.Size(268, 20)
        Me.txtFormatoImagenes.TabIndex = 72
        '
        'lblConfiguracion
        '
        Me.lblConfiguracion.AutoSize = True
        Me.lblConfiguracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfiguracion.ForeColor = System.Drawing.Color.White
        Me.lblConfiguracion.Location = New System.Drawing.Point(3, 9)
        Me.lblConfiguracion.Name = "lblConfiguracion"
        Me.lblConfiguracion.Size = New System.Drawing.Size(195, 20)
        Me.lblConfiguracion.TabIndex = 71
        Me.lblConfiguracion.Text = "Panel de Configuración"
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblTitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Image = Global.Presentador.My.Resources.Resources.VistaPrevia_Blanco
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1378, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "            Presentador 1.1.0 | Panel de Control"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelControlImagen
        '
        Me.panelControlImagen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelControlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.panelControlImagen.Controls.Add(Me.btnImagenPosicion)
        Me.panelControlImagen.Controls.Add(Me.btnImagenLuz)
        Me.panelControlImagen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panelControlImagen.Location = New System.Drawing.Point(694, 91)
        Me.panelControlImagen.Name = "panelControlImagen"
        Me.panelControlImagen.Size = New System.Drawing.Size(548, 63)
        Me.panelControlImagen.TabIndex = 71
        Me.panelControlImagen.Visible = False
        '
        'PanelDeGrabacion
        '
        Me.PanelDeGrabacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelDeGrabacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelDeGrabacion.Controls.Add(Me.chkGrabacionInteligente)
        Me.PanelDeGrabacion.Controls.Add(Me.btnGrabarDetener)
        Me.PanelDeGrabacion.Controls.Add(Me.lblGrabarFilename)
        Me.PanelDeGrabacion.Controls.Add(Me.lblGrabarStatus)
        Me.PanelDeGrabacion.Controls.Add(Me.btnGrabarCompartir)
        Me.PanelDeGrabacion.Controls.Add(Me.btnGrabarToogle)
        Me.PanelDeGrabacion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PanelDeGrabacion.Location = New System.Drawing.Point(526, 699)
        Me.PanelDeGrabacion.Name = "PanelDeGrabacion"
        Me.PanelDeGrabacion.Size = New System.Drawing.Size(784, 56)
        Me.PanelDeGrabacion.TabIndex = 72
        '
        'lblGrabarFilename
        '
        Me.lblGrabarFilename.AutoSize = True
        Me.lblGrabarFilename.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrabarFilename.ForeColor = System.Drawing.Color.White
        Me.lblGrabarFilename.Location = New System.Drawing.Point(168, 19)
        Me.lblGrabarFilename.Name = "lblGrabarFilename"
        Me.lblGrabarFilename.Size = New System.Drawing.Size(0, 13)
        Me.lblGrabarFilename.TabIndex = 67
        '
        'lblGrabarStatus
        '
        Me.lblGrabarStatus.AutoSize = True
        Me.lblGrabarStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblGrabarStatus.ForeColor = System.Drawing.Color.White
        Me.lblGrabarStatus.Location = New System.Drawing.Point(303, 1)
        Me.lblGrabarStatus.Name = "lblGrabarStatus"
        Me.lblGrabarStatus.Size = New System.Drawing.Size(140, 13)
        Me.lblGrabarStatus.TabIndex = 42
        Me.lblGrabarStatus.Text = "No se ha grabado nada aún"
        '
        'timAudioPosicionActual
        '
        '
        'timVideoPosicionActual
        '
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(525, 671)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(204, 20)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Controles de grabación"
        '
        'StatusBar
        '
        Me.StatusBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusBar.AutoSize = False
        Me.StatusBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.StatusBar.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolTipDestination})
        Me.StatusBar.Location = New System.Drawing.Point(3, 758)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1375, 22)
        Me.StatusBar.SizingGrip = False
        Me.StatusBar.TabIndex = 74
        Me.StatusBar.Text = "StatusStrip1"
        '
        'ToolTipDestination
        '
        Me.ToolTipDestination.ForeColor = System.Drawing.Color.White
        Me.ToolTipDestination.Name = "ToolTipDestination"
        Me.ToolTipDestination.Size = New System.Drawing.Size(0, 17)
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(1291, 689)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 68
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'btnReacomodar
        '
        Me.btnReacomodar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReacomodar.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReacomodar.BackgroundImage = Global.Presentador.My.Resources.Resources.AjustarImagen
        Me.btnReacomodar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReacomodar.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnReacomodar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReacomodar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReacomodar.Location = New System.Drawing.Point(1272, 0)
        Me.btnReacomodar.Name = "btnReacomodar"
        Me.btnReacomodar.Size = New System.Drawing.Size(50, 25)
        Me.btnReacomodar.TabIndex = 75
        Me.btnReacomodar.TabStop = False
        Me.btnReacomodar.UseVisualStyleBackColor = False
        '
        'ControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1378, 780)
        Me.Controls.Add(Me.btnReacomodar)
        Me.Controls.Add(Me.pnlCitas)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.btnBug)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.PanelDeGrabacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnConfiguracion)
        Me.Controls.Add(Me.btnCerrarArchivo)
        Me.Controls.Add(Me.lblNombreArchivo)
        Me.Controls.Add(Me.btnLimpiaItem)
        Me.Controls.Add(Me.btnValidarContenido)
        Me.Controls.Add(Me.btnBajarItem)
        Me.Controls.Add(Me.btnAbrirContenidos)
        Me.Controls.Add(Me.btnGuardarContenidos)
        Me.Controls.Add(Me.btnSubirItem)
        Me.Controls.Add(Me.btnLimpiarContenido)
        Me.Controls.Add(Me.btnReestablecePresentadorANegro)
        Me.Controls.Add(Me.pnlCanciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAbreTV)
        Me.Controls.Add(Me.btnAbreWOL)
        Me.Controls.Add(Me.btnAbreJWorg)
        Me.Controls.Add(Me.btnAgregaCita)
        Me.Controls.Add(Me.btnAgregaPDF)
        Me.Controls.Add(Me.btnAgregaCancion)
        Me.Controls.Add(Me.btnAgregaVideo)
        Me.Controls.Add(Me.btnAgregaImagen)
        Me.Controls.Add(Me.btnAgregaAudio)
        Me.Controls.Add(Me.chkAgregaAutomaticamente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReestablecePresentador)
        Me.Controls.Add(Me.btnIniciaPresentador)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.panelControlAudio)
        Me.Controls.Add(Me.panelControlVideo)
        Me.Controls.Add(Me.panelControlPDF)
        Me.Controls.Add(Me.panelControlImagen)
        Me.Controls.Add(Me.lstContenidos)
        Me.Controls.Add(Me.panConfigs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ControlPanel"
        Me.Text = "Presentador 1.0.0 | Panel de Control"
        CType(Me.numCanciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackPDFZoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackVideoVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trackAudioPosition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCanciones.ResumeLayout(False)
        Me.pnlCanciones.PerformLayout()
        Me.pnlCitas.ResumeLayout(False)
        Me.pnlCitas.PerformLayout()
        Me.panelControlPDF.ResumeLayout(False)
        Me.panelControlAudio.ResumeLayout(False)
        Me.panelControlAudio.PerformLayout()
        Me.panelControlVideo.ResumeLayout(False)
        Me.panelControlVideo.PerformLayout()
        CType(Me.trackVideoPosicionActual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panConfigs.ResumeLayout(False)
        Me.panConfigs.PerformLayout()
        Me.panelControlImagen.ResumeLayout(False)
        Me.PanelDeGrabacion.ResumeLayout(False)
        Me.PanelDeGrabacion.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnIniciaPresentador As Button
    Friend WithEvents btnReestablecePresentador As Button
    Friend WithEvents btnAgregaPDF As Button
    Friend WithEvents btnAgregaCancion As Button
    Friend WithEvents btnAgregaVideo As Button
    Friend WithEvents btnAgregaImagen As Button
    Friend WithEvents btnAgregaAudio As Button
    Friend WithEvents chkAgregaAutomaticamente As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregaCita As Button
    Friend WithEvents btnAbreJWorg As Button
    Friend WithEvents btnAbreWOL As Button
    Friend WithEvents btnAbreTV As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lstContenidos As ListView
    Friend WithEvents pnlCanciones As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents numCanciones As NumericUpDown
    Friend WithEvents btnAgregarCancionLista As Button
    Friend WithEvents pnlCitas As Panel
    Friend WithEvents btnAgregaCitaLista As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents panelControlPDF As Panel
    Friend WithEvents btnPDFUltimo As Button
    Friend WithEvents btnPDFSiguiente As Button
    Friend WithEvents btnPDFAnterior As Button
    Friend WithEvents btnPDFPrimero As Button
    Friend WithEvents btnPDFZoomIn As Button
    Friend WithEvents btnPDFZoomOut As Button
    Friend WithEvents trackPDFZoom As TrackBar
    Friend WithEvents btnReestablecePresentadorANegro As Button
    Friend WithEvents panelControlAudio As Panel
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents btnAudioPlayPausa As Button
    Friend WithEvents btnAudioMute As Button
    Friend WithEvents panelControlVideo As Panel
    Friend WithEvents btnVideoFullscreen As Button
    Friend WithEvents btnVideoMute As Button
    Friend WithEvents trackVideoVolume As TrackBar
    Friend WithEvents btnVideoPlayPausa As Button
    Friend WithEvents clmTipo As ColumnHeader
    Friend WithEvents clmFile As ColumnHeader
    Friend WithEvents btnLimpiarContenido As Button
    Friend WithEvents btnSubirItem As Button
    Friend WithEvents btnGuardarContenidos As Button
    Friend WithEvents btnAbrirContenidos As Button
    Friend WithEvents btnBajarItem As Button
    Friend WithEvents btnValidarContenido As Button
    Friend WithEvents btnLimpiaItem As Button
    Friend WithEvents lblNombreArchivo As Label
    Friend WithEvents btnCerrarArchivo As Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label7 As Label
    Friend WithEvents panConfigs As Panel
    Friend WithEvents lblConfiguracion As Label
    Friend WithEvents btnAbreBroadcastingTest As Button
    Friend WithEvents btnAbreWOLTest As Button
    Friend WithEvents btnAbreSitioOficialTest As Button
    Friend WithEvents btnAbreURLBuscador As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatronAntesCanciones As TextBox
    Friend WithEvents txtCarpetaCanciones As TextBox
    Friend WithEvents txtBackgroudImage As TextBox
    Friend WithEvents txtURLBroadcasting As TextBox
    Friend WithEvents txtURLWOL As TextBox
    Friend WithEvents txtSitioOficial As TextBox
    Friend WithEvents txtURLBuscador As TextBox
    Friend WithEvents txtFormatoAudio As TextBox
    Friend WithEvents txtFormatoVideos As TextBox
    Friend WithEvents txtFormatoImagenes As TextBox
    Friend WithEvents btnCancelarConfig As Button
    Friend WithEvents btnBuscaCarpetaCanciones As Button
    Friend WithEvents btnBuscaImagenFondo As Button
    Friend WithEvents btnGuardarConfig As Button
    Friend WithEvents txtPatronDespuesCanciones As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnReestablecer As Button
    Friend WithEvents panelControlImagen As Panel
    Friend WithEvents btnImagenPosicion As Button
    Friend WithEvents btnImagenLuz As Button
    Friend WithEvents PanelDeGrabacion As Panel
    Friend WithEvents btnGrabarCompartir As Button
    Friend WithEvents btnGrabarToogle As Button
    Friend WithEvents lblGrabarFilename As Label
    Friend WithEvents lblGrabarStatus As Label
    Friend WithEvents btnBuscaCarpetaGrabaciones As Button
    Friend WithEvents lblUbicacionGrabaciones As Label
    Friend WithEvents txtCarpetaGrabaciones As TextBox
    Friend WithEvents trackAudioPosition As TrackBar
    Friend WithEvents lblAudioPosition As Label
    Friend WithEvents timAudioPosicionActual As Timer
    Friend WithEvents trackVideoPosicionActual As TrackBar
    Friend WithEvents timVideoPosicionActual As Timer
    Friend WithEvents lblVideoPosition As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnBug As Button
    Friend WithEvents btnGrabarDetener As Button
    Friend WithEvents chkGrabacionInteligente As CheckBox
    Friend WithEvents btnCancionCancelar As Button
    Friend WithEvents btnCancelarCita As Button
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents ToolTipDestination As ToolStripStatusLabel
    Friend WithEvents cmbIdioma As ComboBox
    Friend WithEvents lblIdioma As Label
    Friend WithEvents chkMelodias As CheckBox
    Friend WithEvents btnReacomodar As Button
End Class
