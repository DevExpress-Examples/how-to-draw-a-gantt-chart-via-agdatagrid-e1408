Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports DevExpress.AgDataGrid

Namespace GanttExample
	Partial Public Class Page
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.DataSource = Source.CreateSource()
			AddHandler grid.Loaded, AddressOf grid_Loaded
		End Sub

		Private Sub grid_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			grid.ApplyTemplate()
			For Each column As AgDataGridColumn In grid.Columns
				If column.FieldName = "Value" Then
					Continue For
				End If
				column.DisplayTemplate = TryCast(grid.Resources("dt"), ControlTemplate)
			Next column
		End Sub
	End Class
	Public Class ValConv
		Implements IValueConverter

		#Region "IValueConverter Members"

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If Not value Is Nothing AndAlso CInt(value) = 1 Then
				Return 1
			End If
			Return 0
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		#End Region
	End Class
	Public Class LineConv
		Implements IValueConverter

		#Region "IValueConverter Members"

		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			If Not value Is Nothing AndAlso CInt(value) = 2 Then
				Return 1
			End If
			Return 0
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		#End Region
	End Class
	Public Class Source
		Private privateValue As Integer
		Public Property Value() As Integer
			Get
				Return privateValue
			End Get
			Set(ByVal value As Integer)
				privateValue = value
			End Set
		End Property
		Private privateJan As Integer
		Public Property Jan() As Integer
			Get
				Return privateJan
			End Get
			Set(ByVal value As Integer)
				privateJan = value
			End Set
		End Property
		Private privateFeb As Integer
		Public Property Feb() As Integer
			Get
				Return privateFeb
			End Get
			Set(ByVal value As Integer)
				privateFeb = value
			End Set
		End Property
		Private privateMar As Integer
		Public Property Mar() As Integer
			Get
				Return privateMar
			End Get
			Set(ByVal value As Integer)
				privateMar = value
			End Set
		End Property
		Private privateApr As Integer
		Public Property Apr() As Integer
			Get
				Return privateApr
			End Get
			Set(ByVal value As Integer)
				privateApr = value
			End Set
		End Property
		Private privateMay As Integer
		Public Property May() As Integer
			Get
				Return privateMay
			End Get
			Set(ByVal value As Integer)
				privateMay = value
			End Set
		End Property
		Private privateJun As Integer
		Public Property Jun() As Integer
			Get
				Return privateJun
			End Get
			Set(ByVal value As Integer)
				privateJun = value
			End Set
		End Property
		Private privateJul As Integer
		Public Property Jul() As Integer
			Get
				Return privateJul
			End Get
			Set(ByVal value As Integer)
				privateJul = value
			End Set
		End Property
		Private privateAug As Integer
		Public Property Aug() As Integer
			Get
				Return privateAug
			End Get
			Set(ByVal value As Integer)
				privateAug = value
			End Set
		End Property
		Private privateSep As Integer
		Public Property Sep() As Integer
			Get
				Return privateSep
			End Get
			Set(ByVal value As Integer)
				privateSep = value
			End Set
		End Property
		Private privateOct As Integer
		Public Property Oct() As Integer
			Get
				Return privateOct
			End Get
			Set(ByVal value As Integer)
				privateOct = value
			End Set
		End Property
		Private privateNov As Integer
		Public Property Nov() As Integer
			Get
				Return privateNov
			End Get
			Set(ByVal value As Integer)
				privateNov = value
			End Set
		End Property
		Private privateDec As Integer
		Public Property Dec() As Integer
			Get
				Return privateDec
			End Get
			Set(ByVal value As Integer)
				privateDec = value
			End Set
		End Property
		Public Sub New(ByVal val As Integer, ByVal a1 As Integer, ByVal a2 As Integer, ByVal a3 As Integer, ByVal a4 As Integer, ByVal a5 As Integer, ByVal a6 As Integer, ByVal a7 As Integer, ByVal a8 As Integer, ByVal a9 As Integer, ByVal a10 As Integer, ByVal a11 As Integer, ByVal a12 As Integer)
			Value = val
			Jan = a1
			Feb = a2
			Mar = a3
			Apr = a4
			May = a5
			Jun = a6
			Jul = a7
			Aug = a8
			Sep = a9
			Oct = a10
			Nov = a11
			Dec = a12
		End Sub
		Public Shared Function CreateSource() As List(Of Source)
			Dim res As New List(Of Source)()
			res.Add(New Source(1, 1, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
			res.Add(New Source(2, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
			res.Add(New Source(3, 0, 2, 0, 0, 1, 1, 2, 0, 0, 0, 0, 0))
			res.Add(New Source(4, 0, 1, 2, 0, 2, 0, 2, 0, 0, 0, 0, 0))
			res.Add(New Source(5, 0, 0, 2, 0, 2, 0, 2, 0, 0, 0, 0, 0))
			res.Add(New Source(6, 0, 0, 2, 0, 2, 0, 1, 2, 0, 0, 0, 0))
			res.Add(New Source(7, 0, 0, 2, 0, 2, 0, 0, 2, 0, 0, 0, 0))
			res.Add(New Source(8, 0, 0, 1, 1, 2, 0, 0, 2, 0, 0, 1, 1))
			res.Add(New Source(9, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 2, 0))
			res.Add(New Source(10, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 2, 0))
			res.Add(New Source(11, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0))
			Return res

		End Function
	End Class

End Namespace
