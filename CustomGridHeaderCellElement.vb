Imports Telerik.WinControls
Imports Telerik.WinControls.UI
' Step 1: Create a custom GridHeaderCellElement
Public Class CustomGridHeaderCellElement
    Inherits GridHeaderCellElement

    Public Sub New(column As GridViewColumn, row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
        Get
            Return GetType(GridHeaderCellElement)
        End Get
    End Property

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()
        'AddHandler Me.GridControl.FilterChanged, AddressOf GridControl_FilterChanged
    End Sub

    Private Sub GridControl_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs)
        UpdateFilterButtonColor()
    End Sub

    Public Sub UpdateFilterButtonColor()
        Dim dataColumn As GridViewDataColumn = TryCast(Me.ColumnInfo, GridViewDataColumn)

        If dataColumn IsNot Nothing AndAlso IsFilterActive(dataColumn) Then
            ' Change the header cell button's color when a filter is active
            Me.FilterButton.ForeColor = Color.Red
        Else
            ' Reset the header cell button's color when a filter is inactive
            Me.FilterButton.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub

    Private Function IsFilterActive(column As GridViewDataColumn) As Boolean
        For Each descriptor As Telerik.WinControls.Data.FilterDescriptor In column.OwnerTemplate.FilterDescriptors
            If descriptor.PropertyName = column.Name Then
                Return True
            End If
        Next
        Return False
    End Function
End Class


' Step 1: Create a custom GridHeaderCellElement
'Public Class CustomGridHeaderCellElement
'    Inherits GridHeaderCellElement

'    Public Sub New(column As GridViewColumn, row As GridRowElement)
'        MyBase.New(column, row)
'    End Sub

'    Protected Overrides ReadOnly Property ThemeEffectiveType As Type
'        Get
'            Return GetType(GridHeaderCellElement)
'        End Get
'    End Property

'    Public Sub UpdateFilterButtonColor()
'        Dim dataColumn As GridViewDataColumn = TryCast(Me.ColumnInfo, GridViewDataColumn)

'        If dataColumn IsNot Nothing AndAlso IsFilterActive(dataColumn) Then
'            ' Change the header cell button's color when a filter is active
'            Me.FilterButton.ForeColor = Color.Red
'        Else
'            ' Reset the header cell button's color when a filter is inactive
'            Me.FilterButton.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
'        End If
'    End Sub

'    Private Function IsFilterActive(column As GridViewDataColumn) As Boolean
'        For Each descriptor As Telerik.WinControls.Data.FilterDescriptor In column.OwnerTemplate.FilterDescriptors
'            If descriptor.PropertyName = column.Name Then
'                Return True
'            End If
'        Next
'        Return False
'    End Function
'End Class
