using System;

namespace Stack{
    interface IStack<T>{
        void push(T value);
        T pop();
        T peek();
        bool isEmpty();
    }
}