using System;

namespace Stack{
    interface IStack<T>{
        void push(T e);
        T pop();
        T peek();
        bool isEmpty();
    }
}