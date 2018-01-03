using System;

namespace Doubly_List{
    class DoublyLinkedList{
        private Node head;
        private Node tail;

        public void insertBefore(int value, int before){
            if(this.head == null){
                this.head = new Node(null, value, this.head);
                return;
            }

            if(this.head.value > value){
                Node tmp = new Node(null, value, this.head);
                this.head.prev = tmp;
                this.head = tmp;
                //Console.WriteLine(this.head.next.prev.value);
                return;
            }

            Node x = this.head;
            while(x.next != null && x.next.value != before){
                x = x.next;
            }
            x.next = new Node(x, value, x.next);
            this.tail = new Node(x, value, x.next);
            return;
        }

        public void insertAfter(int value, int after){
            if(this.head == null){
                this.head = new Node(null, value, this.head);
                return;
            }

            Node x = this.head;
            while(x.next != null && x.value != after){
                x = x.next;
            }
            x.next = new Node(x, value, x.next);
            this.tail = new Node(x, value, x.next);
            return;
        }

        public void insertBeginning(int value){
            this.head = new Node(null, value, this.head);
            return;
        }

        public void insertEnd(int value){
            Node x = this.head;
            while(x.next != null){
                x = x.next;
            }
            x.next = new Node(x, value, x.next);
            this.tail = new Node(x, value, x.next);
            return;
        }

        public void delete(int value){
            Node x = this.head;
            while(x.next != null){
                if(x.next.value == value){
                    x.next = x.next.next;
                    return;
                }
                x = x.next;
            }
            return;
        }

        public void print(){
            Console.WriteLine(this.head.value);
            Node x = this.tail;
            while(x != null){
                Console.WriteLine(x.value);
                x = x.prev;
            }
            Console.WriteLine(this.tail.value);
        }
    }
}