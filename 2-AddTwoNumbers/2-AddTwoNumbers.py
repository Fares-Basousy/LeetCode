# Last updated: 7/1/2025, 5:57:24 PM
# Definition for singly-linked list.
# class ListNode(object):
#     def _init_(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def addTwoNumbers(self, l1, l2):
        list1=list2=""
        while l1!=None:
            list1+=str(l1.val)
            l1=l1.next
        while l2!=None:
            list2+=str(l2.val)
            l2=l2.next
        list1=list1[::-1]
        list2=list2[::-1]
        sum1=int(list1)+int(list2)
        listl=[]
        sum1=list(str(sum1))
        sum1=sum1[::-1]
        listl[:0]=sum1
        listob=[]
        for i in listl[0::]:
            node= ListNode(int(i))
            listob.append(node)
        for i in range(len(listob)-1,0,-1):
            if i == 0:
                break
            listob[i-1].next=listob[i]
        return listob[0]    
            
                                        
             
        
        """
        :type l1: ListNode
        :type l2: ListNode
        :rtype: ListNode
        """