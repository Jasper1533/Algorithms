using System;

namespace Stack{
    class Stack<T>: IStack<T>{
        private T[] s;
        private int stack_index;

        public Stack(int size){
            if(size < 0){
                throw new ArgumentOutOfRangeException("size");
            }

            s = new T[size];
            stack_index = -1;
        }

        public void push(T value){
            stack_index++;

            if (stack_index + 1 >= s.Length){
                //Notice the + 1, to counter the 0 length problem
                Array.Resize(ref s, (s.Length + 1)*2);            
            }
            
            s[stack_index] = value;
        }
        public T pop(){
            if(this.isEmpty()){
                throw new InvalidOperationException("The stack is empty");
            }
            T value = s[--stack_index];

            return value;
        }
        public T peek(){
            T value = s[stack_index];
            return value;
        }
        public bool isEmpty(){
            if(stack_index == -1){
                return true;
            }
            return false;
        }
    }
}