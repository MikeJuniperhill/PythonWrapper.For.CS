using System;
using System.Dynamic;

namespace CsLibrary {

    public class PyWrapper : DynamicObject {

        // wrapped C# class
        private CsLibrary.Functions functions;

        // ctor
        public PyWrapper() {
            functions = new CsLibrary.Functions();
        }        
        
        public double Add(double a, double b) {
            return functions.Add(a, b);
        }

        public double Subtract(double a, double b) {
            return functions.Subtract(a, b);
        }

        public double Multiply(double a, double b) {
            return functions.Multiply(a, b);
        }

        public double Divide(double a, double b) {
            return functions.Divide(a, b);
        }
    }
}
