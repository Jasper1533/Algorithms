using System;

namespace List{
    class LinkedList{
        private Node head;

        public void insert(int value){
            if(this.head == null || this.head.value > value){
                this.head = new Node(this.head, value);
                return;
            }

            Node x = this.head;
            while(x.next != null && x.next.value <= value){
                x = x.next;
            }
            x.next = new Node(x.next, value);
            return;
        }

        public void delete(int value){
            if(this.head == null || this.head.value > value){
                return;
            } else if(this.head.value == value) {
                this.head = this.head.next;
            }

            Node x = this.head;
            while(x.next != null && x.next.value <= value){
                if(x.next.value == value){
                    x.next = x.next.next;
                    return;
                }
                x = x.next;
            }
            return;
        }

        public bool search(int value){
            Node x = this.head;
            while(x != null && x.next != null && x.value != value){
                x = x.next;
            }
            return x.value == value ? true : false;
        }

        public void print(){
            Node x = this.head;
            while(x != null){
                Console.WriteLine(x.value);
                x = x.next;
            }
        }
    }
}