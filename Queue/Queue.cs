using System;

namespace Queue{
    class Queue<T>: IQueue<T>{
        private T[] queue;
        private int front;
        private int back;

        public Queue(int size){
            if(size < 0){
                throw new ArgumentOutOfRangeException("size");
            }

            queue = new T[size];
            front = 0;
            back = -1;
        }
        public void enqueue(T value){
            back++;
            if (back + 1 >= queue.Length){
                //Notice the + 1, to counter the 0 length problem
                Array.Resize(ref queue, (queue.Length + 1)*2);
            }
            queue[back] = value;
        }
        public T peek(){
            return queue[front];
        }
        public T dequeue(){
            if(this.isEmpty()){
                throw new InvalidOperationException("The queue is empty");
            }
            T value = queue[front];
            front++;

            return value;
        }
        public bool isEmpty(){
            if(front < 0 || front > back){
                return true;
            }
            return false;
        }
    }
}