'****************************************************************************   
'                      (C) Copyright by Odysee
'                                                                                 
'Module   : LibVlc.cs
'SCCS     : $Archive: $ $Revision:  $
'Author   : Odysee
'Date     : 10.11.2006
'Last Change : $Date: $ $Author: $ 
'Description :
'
'Known problems :
'
'Modification history :
'     Date   | Usr.| Comment
'   ---------+-----+----------------------------------------------------------   
'            |     |
'*****************************************************************************

Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports Microsoft.Win32

Namespace LibVLC
    '***************************************************************************
    '    Class name     :  LibVlc
    '    Author         :  Odysee
    '    Date           :  22.12.2005
    '    Description    : 
    '
    '    Known problems :
    '
    '    Modification history :
    '
    '      Date   | Usr.| Comment
    '    ---------+-----+----------------------------------------------------------
    '             |     |
    '    ***************************************************************************

    ''' <summary>
    ''' Class LibVlc
    ''' </summary>
    Public Class LibVlc
        '---------------------------------------------------------------------
        ' -- public enums
#Region "public enums"

        Public Enum [Error]
            Success = -0
            NoMem = -1
            Thread = -2
            Timeout = -3

            NoMod = -10

            NoObj = -20
            BadObj = -21

            NoVar = -30
            BadVar = -31

            [Exit] = -255
            Generic = -666

            Execption = -998
            NoInit = -999
        End Enum

        Private Enum Mode
            Insert = &H1
            Replace = &H2
            Append = &H4
            Go = &H8
            CheckInsert = &H10
        End Enum

        Private Enum Pos
            [End] = -666
        End Enum

#End Region
        '---------------------------------------------------------------------

        '---------------------------------------------------------------------
        ' -- public  structs
#Region "public structs"
        <StructLayout(LayoutKind.Explicit)> _
        Public Structure vlc_value_t
            <FieldOffset(0)> _
            Public i_int As Int32
            <FieldOffset(0)> _
            Public b_bool As Int32
            <FieldOffset(0)> _
            Public f_float As Single
            <FieldOffset(0)> _
            Public psz_string As IntPtr
            <FieldOffset(0)> _
            Public p_address As IntPtr
            <FieldOffset(0)> _
            Public p_object As IntPtr
            <FieldOffset(0)> _
            Public p_list As IntPtr
            <FieldOffset(0)> _
            Public i_time As Int64

            <FieldOffset(0)> _
            Public psz_name As IntPtr
            <FieldOffset(4)> _
            Public i_object_id As Int32
        End Structure
#End Region
        '---------------------------------------------------------------------

        '---------------------------------------------------------------------
        ' -- libvlc api
#Region "libvlc api"
        <DllImport("libvlc")> _
        Private Shared Function VLC_Create() As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Init(ByVal iVLC As Integer, ByVal Argc As Integer, ByVal Argv As String()) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_AddIntf(ByVal iVLC As Integer, ByVal Name As String, ByVal Block As Boolean, ByVal Play As Boolean) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Die(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Error() As String
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Version() As String
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_CleanUp(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Destroy(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_AddTarget(ByVal iVLC As Integer, ByVal Target As String, ByVal Options As String(), ByVal OptionsCount As Integer, ByVal Mode As Integer, ByVal Pos As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Play(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Pause(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Stop(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_IsPlaying(ByVal iVLC As Integer) As Boolean
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PositionGet(ByVal iVLC As Integer) As Single
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PositionSet(ByVal iVLC As Integer, ByVal Pos As Single) As Single
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_TimeGet(ByVal iVLC As Integer) As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_TimeSet(ByVal iVLC As Integer, ByVal Seconds As Integer, ByVal Relative As Boolean) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_LengthGet(ByVal iVLC As Integer) As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_SpeedFaster(ByVal iVLC As Integer) As Single
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_SpeedSlower(ByVal iVLC As Integer) As Single
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PlaylistIndex(ByVal iVLC As Integer) As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PlaylistNumberOfItems(ByVal iVLC As Integer) As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PlaylistNext(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PlaylistPrev(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_PlaylistClear(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_VolumeSet(ByVal iVLC As Integer, ByVal Volume As Integer) As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_VolumeGet(ByVal iVLC As Integer) As Integer
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_VolumeMute(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_FullScreen(ByVal iVLC As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_VariableType(ByVal iVLC As Integer, ByVal Name As String, ByRef iType As Integer) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_VariableSet(ByVal iVLC As Integer, ByVal Name As String, ByVal value As vlc_value_t) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_VariableGet(ByVal iVLC As Integer, ByVal Name As String, ByRef value As vlc_value_t) As [Error]
        End Function
        <DllImport("libvlc")> _
        Private Shared Function VLC_Error(ByVal i_err As Integer) As String
        End Function
#End Region
        '---------------------------------------------------------------------

        '---------------------------------------------------------------------
        ' -- local members
#Region "local members"
        Private m_iVlcHandle As Integer = -1
        Private m_wndOutput As Control = Nothing
        Private m_strVlcInstallDir As String = ""
        Private m_strLastError As String = ""
#End Region
        '---------------------------------------------------------------------

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   LibVlc Constructor
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Sub New()
            m_strVlcInstallDir = System.AppDomain.CurrentDomain.BaseDirectory
            'QueryVlcInstallPath()
        End Sub

        '=======================================================================*
        '         *=======================================================================*
        '         *==                IDisposable MEMBERS                            ==*
        '         *=======================================================================*
        '         *=======================================================================

#Region "IDisposable Members"

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   Dispose
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Sub Dispose()
            If m_iVlcHandle <> -1 Then
                Try
                    VLC_CleanUp(m_iVlcHandle)
                    VLC_Destroy(m_iVlcHandle)
                    VideoOutput = Nothing
                Catch
                End Try
            End If
            m_iVlcHandle = -1
        End Sub
#End Region

        '=======================================================================*
        '         *=======================================================================*
        '         *==                PUBLIC PROPERTIES                              ==*
        '         *=======================================================================*
        '         *=======================================================================

#Region "PUBLIC PROPERTIES"

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   VlcInstallDir
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Property VlcInstallDir() As String
            Get
                Return m_strVlcInstallDir
            End Get
            Set(ByVal value As String)
                m_strVlcInstallDir = value
            End Set
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   IsInitialized
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property IsInitialized() As Boolean
            Get
                Return (m_iVlcHandle <> -1)
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   VideoOutput
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Property VideoOutput() As Control
            Get
                Return m_wndOutput
            End Get
            Set(ByVal value As Control)
                ' clear old window
                If m_wndOutput IsNot Nothing Then
                    RemoveHandler m_wndOutput.Resize, AddressOf wndOutput_Resize
                    m_wndOutput = Nothing
                    If m_iVlcHandle <> -1 Then
                        SetVariable("drawable", 0)
                    End If
                End If

                ' set new
                m_wndOutput = value
                If m_wndOutput IsNot Nothing Then
                    If m_iVlcHandle <> -1 Then
                        SetVariable("drawable", m_wndOutput.Handle.ToInt32())
                    End If
                    AddHandler m_wndOutput.Resize, AddressOf wndOutput_Resize
                    wndOutput_Resize(Nothing, Nothing)
                End If
            End Set
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   LastError
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property LastError() As String
            Get
                Return m_strLastError
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   IsPlaying
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property IsPlaying() As Boolean
            Get
                If m_iVlcHandle = -1 Then
                    m_strLastError = "LibVlc is not initialzed"
                    Return False
                End If

                Try
                    Return VLC_IsPlaying(m_iVlcHandle)
                Catch ex As Exception
                    m_strLastError = ex.Message
                    Return False
                End Try
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   LengthGet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property LengthGet() As Integer
            Get
                If m_iVlcHandle = -1 Then
                    m_strLastError = "LibVlc is not initialzed"
                    Return -1
                End If

                Try
                    Return VLC_LengthGet(m_iVlcHandle)
                Catch ex As Exception
                    m_strLastError = ex.Message
                    Return -1
                End Try
            End Get
        End Property


        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   TimeGet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property TimeGet() As Integer
            Get
                If m_iVlcHandle = -1 Then
                    m_strLastError = "LibVlc is not initialzed"
                    Return -1
                End If

                Try
                    Return VLC_TimeGet(m_iVlcHandle)
                Catch ex As Exception
                    m_strLastError = ex.Message
                    Return -1
                End Try
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   PositionGet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property PositionGet() As Single
            Get
                If m_iVlcHandle = -1 Then
                    m_strLastError = "LibVlc is not initialzed"
                    Return -1
                End If

                Try
                    Return VLC_PositionGet(m_iVlcHandle)
                Catch ex As Exception
                    m_strLastError = ex.Message
                    Return -1
                End Try
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   PlaylistNumberOfItems
        ''' Author         :   James Weston
        '''   Date         :   20/01/2009
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property PlaylistNumberOfItems() As Integer
            Get
                If m_iVlcHandle = -1 Then
                    m_strLastError = "LibVlc is not initialzed"
                    Return -1
                End If

                Try
                    Return VLC_PlaylistNumberOfItems(m_iVlcHandle)
                Catch ex As Exception
                    m_strLastError = ex.Message
                    Return -1
                End Try
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   VolumeGet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public ReadOnly Property VolumeGet() As Integer
            Get
                If m_iVlcHandle = -1 Then
                    m_strLastError = "LibVlc is not initialzed"
                    Return -1
                End If

                Try
                    Return VLC_VolumeGet(m_iVlcHandle)
                Catch ex As Exception
                    m_strLastError = ex.Message
                    Return -1
                End Try
            End Get
        End Property

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   Fullscreen
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Property Fullscreen() As Boolean
            Get
                Dim iIsFullScreen As Integer = 0
                If GetVariable("fullscreen", iIsFullScreen) = [Error].Success Then
                    If iIsFullScreen <> 0 Then
                        Return True
                    End If
                End If
                Return False

            End Get
            Set(ByVal value As Boolean)
                Dim iFullScreen As Integer = If(value, 1, 0)


                SetVariable("fullscreen", iFullScreen)
            End Set
        End Property

#End Region



        '=======================================================================*
        '         *=======================================================================*
        '         *==                PUBLIC METHODS                                 ==*
        '         *=======================================================================*
        '         *=======================================================================

#Region "PUBLIC METHODS"


        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   Initialize
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function Initialize() As Boolean
            ' check if already initializes
            If m_iVlcHandle <> -1 Then
                Return True
            End If

            ' try init
            Try
                ' create instance
                m_iVlcHandle = VLC_Create()
                If m_iVlcHandle < 0 Then
                    m_strLastError = "Failed to create VLC instance"
                    Return False
                End If

                ' make init optinons
                'Dim strInitOptions As String() = {"vlc", "--no-one-instance", "--no-loop", "--no-drop-late-frames", "--disable-screensaver"}
                'If m_strVlcInstallDir.Length > 0 Then
                'strInitOptions(0) = m_strVlcInstallDir & "\vlc"
                'End If
                Dim userFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\" + My.Application.Info.CompanyName + "\" + My.Application.Info.AssemblyName + "\cfg.config"
                Dim logFilePath As String = "startup.log"
                Dim strInitOptions As String() = {m_strVlcInstallDir, "--no-one-instance", "--no-loop", "--no-drop-late-frames", "--disable-screensaver", "--config=" + userFilePath, "--save-config"}

                ' init libvlc
                Dim errVlcLib As [Error] = VLC_Init(m_iVlcHandle, strInitOptions.Length, strInitOptions)
                If errVlcLib <> [Error].Success Then
                    VLC_Destroy(m_iVlcHandle)
                    m_strLastError = "Failed to initialise VLC"
                    m_iVlcHandle = -1
                    Return False
                End If

            Catch
                m_strLastError = "Could not find libvlc"
                Return False
            End Try

            ' check output window
            If m_wndOutput IsNot Nothing Then
                SetVariable("drawable", m_wndOutput.Handle.ToInt32())
                wndOutput_Resize(Nothing, Nothing)
            End If

            ' OK
            Return True
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   AddTarget
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function AddTarget(ByVal Target As String) As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_AddTarget(m_iVlcHandle, Target, Nothing, 0, CInt(Mode.Append), CInt(Pos.[End]))
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   AddTarget
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function AddTarget(ByVal Target As String, ByVal Options As String()) As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            ' check options
            Dim iOptionsCount As Integer = 0
            If Options IsNot Nothing Then
                iOptionsCount = Options.Length
            End If

            ' add
            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_AddTarget(m_iVlcHandle, Target, Options, iOptionsCount, CInt(Mode.Append), CInt(Pos.[End]))
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   Play
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function Play() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_Play(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success

        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   Pause
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function Pause() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_Pause(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   Stop
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function [Stop]() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_Stop(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   SpeedFaster
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function SpeedFaster() As Single
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return -1
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                Return VLC_SpeedFaster(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return -1
            End Try
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   SpeedSlower
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function SpeedSlower() As Single
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return -1
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                Return VLC_SpeedSlower(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return -1
            End Try
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   PlaylistNext
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function PlaylistNext() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If
            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_PlaylistNext(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success


        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   PlaylistPrevious
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function PlaylistPrevious() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_PlaylistPrev(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success

        End Function


        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   PlaylistClear
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function PlaylistClear() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_PlaylistClear(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   TimeSet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function TimeSet(ByVal newPosition As Integer, ByVal bRelative As Boolean) As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_TimeSet(m_iVlcHandle, newPosition, bRelative)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   PositionSet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function PositionSet(ByVal newPosition As Single) As Single
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return -1
            End If

            Try
                Return VLC_PositionSet(m_iVlcHandle, newPosition)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return -1
            End Try
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   VolumeSet
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function VolumeSet(ByVal newVolume As Integer) As Integer
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return -1
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                Return VLC_VolumeSet(m_iVlcHandle, newVolume)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return -1
            End Try
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   VolumeMute
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function VolumeMute() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_VolumeMute(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   SetVariable
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function SetVariable(ByVal strName As String, ByVal Value As Int32) As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                ' create vlc value
                Dim val As New vlc_value_t()
                val.i_int = Value

                ' set variable
                enmErr = VLC_VariableSet(m_iVlcHandle, strName, val)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   SetVariable
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function GetVariable(ByVal strName As String, ByRef Value As Integer) As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If



            Dim enmErr As [Error] = [Error].Success
            Try
                ' create vlc value
                Dim val As New vlc_value_t()

                ' set variable
                enmErr = VLC_VariableGet(m_iVlcHandle, strName, val)
                Value = val.i_int
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function


        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   ToggleFullscreen
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function ToggleFullscreen() As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                enmErr = VLC_FullScreen(m_iVlcHandle)
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   ToggleFullscreen
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Public Function PressKey(ByVal strKey As String) As [Error]
            If m_iVlcHandle = -1 Then
                m_strLastError = "LibVlc is not initialzed"
                Return [Error].NoInit
            End If

            Dim enmErr As [Error] = [Error].Success
            Try
                ' create vlc value
                Dim valKey As New vlc_value_t()

                ' get variable
                enmErr = VLC_VariableGet(m_iVlcHandle, strKey, valKey)
                If enmErr = [Error].Success Then
                    ' set pressed
                    enmErr = VLC_VariableSet(m_iVlcHandle, "key-pressed", valKey)
                End If
            Catch ex As Exception
                m_strLastError = ex.Message
                Return [Error].Execption
            End Try

            If CInt(enmErr) < 0 Then
                m_strLastError = VLC_Error(CInt(enmErr))
                Return enmErr
            End If

            ' OK
            Return [Error].Success
        End Function

#End Region



        '=======================================================================*
        '         *=======================================================================*
        '         *==                PRIVATE METHODS                                ==*
        '         *=======================================================================*
        '         *=======================================================================

#Region "PRIVATE METHODS"


        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   QueryVlcInstallPath
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Private Function QueryVlcInstallPath() As String
            ' open registry
            Dim regkeyVlcInstallPathKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\VideoLAN\VLC")
            If regkeyVlcInstallPathKey Is Nothing Then
                Return ""
            End If
            Return DirectCast(regkeyVlcInstallPathKey.GetValue("InstallDir", ""), String)
        End Function

#End Region

        '=======================================================================*
        '         *=======================================================================*
        '         *==                EVENT METHODS                                  ==*
        '         *=======================================================================*
        '         *=======================================================================

#Region "EVENT METHODS"


        ''' -------------------------------------------------------------------
        ''' <summary>
        ''' Method name      :   wndOutput_Resize
        ''' Author         :   Odysee
        '''   Date         :   10.11.2006
        ''' </summary>
        ''' -------------------------------------------------------------------
        Private Sub wndOutput_Resize(ByVal sender As Object, ByVal e As EventArgs)
            If m_iVlcHandle <> -1 Then
                SetVariable("conf::width", m_wndOutput.ClientRectangle.Width)
                SetVariable("conf::height", m_wndOutput.ClientRectangle.Height)
            End If

        End Sub

#End Region
    End Class
End Namespace
