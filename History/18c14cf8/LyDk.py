class QuickSort:
    def Quick(array):
        if len(array)<=1:
            return array
        pivote=array.pop2()

        p=[]#list 1
        q=[]#list 2
        for i in array:
            if i <= array:
                p.append(i)
            else:
                q.append(i)
        p=Quick()