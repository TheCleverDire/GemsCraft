Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection

Namespace ConfigGUI

    ' SortableBindingList by Tim Van Wassenhove, http://www.timvw.be/presenting-the-sortablebindinglistt/
    <Serializable> _
    Public NotInheritable Class SortableBindingList(Of T)
        Inherits BindingList(Of T)
        Private isSorted As Boolean
        Private dir As ListSortDirection = ListSortDirection.Ascending

        <NonSerialized> _
        Private sortObj As PropertyDescriptor

#Region "BindingList<T> Public Sorting API"

        Public Sub Sort()
            ApplySortCore(sortObj, dir)
        End Sub


        Public Sub Sort([property] As String)
            ' Get the PD 

            sortObj = FindPropertyDescriptor([property])

            ' Sort 

            ApplySortCore(sortObj, dir)
        End Sub


        Public Sub Sort([property] As String, direction As ListSortDirection)
            ' Get the sort property 

            sortObj = FindPropertyDescriptor([property])
            dir = direction

            ' Sort 

            ApplySortCore(sortObj, dir)
        End Sub

#End Region


#Region "BindingList<T> Sorting Overrides"

        Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
            Get
                Return True
            End Get
        End Property


        Protected Overrides Sub ApplySortCore(prop As PropertyDescriptor, direction As ListSortDirection)
            Dim items__1 As List(Of T) = TryCast(Items, List(Of T))

            If items__1 IsNot Nothing Then
                Dim pc As New PropertyComparer(Of T)(prop, direction)
                items__1.Sort(pc)

                ' Set sorted 

                isSorted = True
            Else
                ' Set sorted 

                isSorted = False
            End If
        End Sub


        Protected Overrides ReadOnly Property IsSortedCore() As Boolean
            Get
                Return isSorted
            End Get
        End Property


        Protected Overrides Sub RemoveSortCore()
            isSorted = False
        End Sub

#End Region


#Region "BindingList<T> Private Sorting API"

        Private Shared Function FindPropertyDescriptor([property] As String) As PropertyDescriptor
            Dim pdc As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
            Dim prop As PropertyDescriptor = pdc.Find([property], True)
            Return prop
        End Function

#End Region


#Region "PropertyComparer<TKey>"
        Friend NotInheritable Class PropertyComparer(Of TKey)
            Implements IComparer(Of TKey)
            '
            '            * The following code contains code implemented by Rockford Lhotka:
            '            * //msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp" href="http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp">http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dnadvnet/html/vbnet01272004.asp
            '            


            Private ReadOnly [property] As PropertyDescriptor
            Private ReadOnly direction As ListSortDirection

            Public Sub New([property] As PropertyDescriptor, direction As ListSortDirection)
                Me.[property] = [property]
                Me.direction = direction
            End Sub


            Public Function Equals(xVal As TKey, yVal As TKey) As Boolean
                Return xVal.Equals(yVal)
            End Function

            Public Function GetHashCode(obj As TKey) As Integer
                Return obj.GetHashCode()
            End Function

            ' Compare two property values of any type 

            Private Shared Function CompareAscending(xValue As Object, yValue As Object) As Integer
                Dim result As Integer

                ' If values implement IComparer 

                If TypeOf xValue Is IComparable Then
                    result = DirectCast(xValue, IComparable).CompareTo(yValue)
                    ' If values don't implement IComparer but are equivalent 

                ElseIf xValue.Equals(yValue) Then
                    result = 0
                Else
                    ' Values don't implement IComparer and are not equivalent, so compare as string values 

                    result = xValue.ToString().CompareTo(yValue.ToString())
                End If

                ' Return result 

                Return result
            End Function

            Private Shared Function CompareDescending(xValue As Object, yValue As Object) As Integer
                ' Return result adjusted for ascending or descending sort order ie
                '                   multiplied by 1 for ascending or -1 for descending 

                Return CompareAscending(xValue, yValue) * -1
            End Function

            Private Shared Function GetPropertyValue(value As TKey, [property] As String) As Object
                ' Get property 

                Dim propertyInfo As PropertyInfo = value.[GetType]().GetProperty([property])

                ' Return value 

                Return propertyInfo.GetValue(value, Nothing)
            End Function

            Public Function Compare(x As TKey, y As TKey) As Integer Implements IComparer(Of TKey).Compare
                ' Get property values 

                Dim xValue As Object = GetPropertyValue(x, [property].Name)
                Dim yValue As Object = GetPropertyValue(y, [property].Name)

                For Each comparisonResult As Integer In From sortableAtt In [property].Attributes.OfType(Of SortablePropertyAttribute)() Select sortableAtt.Compare([property].Name, x, y)
                    If direction = ListSortDirection.Ascending Then
                        Return comparisonResult
                    Else
                        Return -comparisonResult
                    End If
                Next

                ' Determine sort order 

                If direction = ListSortDirection.Ascending Then
                    Return CompareAscending(xValue, yValue)
                Else
                    Return CompareDescending(xValue, yValue)
                End If
            End Function
        End Class
#End Region
    End Class


    <AttributeUsage(AttributeTargets.[Property])> _
    Public NotInheritable Class SortablePropertyAttribute
        Inherits Attribute
        Public Sub New(type As Type, comparerMethodName As String)
            If type Is Nothing Then
                Throw New ArgumentNullException("type")
            End If
            If comparerMethodName Is Nothing Then
                Throw New ArgumentNullException("comparerMethodName")
            End If
            method = type.GetMethod(comparerMethodName)
            If method Is Nothing Then
                Throw New ArgumentException("No such method", "comparerMethodName")
            End If
        End Sub


        ReadOnly method As MethodInfo
        Public Function Compare(propertyName As String, a As Object, b As Object) As Integer
            Dim methodArgs As Object() = {propertyName, a, b}
            Return CInt(method.Invoke(Nothing, methodArgs))
        End Function
    End Class
End Namespace