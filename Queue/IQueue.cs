using System;

namespace Queue{
    interface IQueue<T>{
        void enqueue(T value);
        T peek();
        T dequeue();
        bool isEmpty();
    }
}