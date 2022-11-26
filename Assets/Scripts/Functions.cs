using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions {
    public class VectorFunctions {
        public static Vector2 AngularToCartesian(Vector2 input) {
            Vector2 output = Vector2.one;

            output.x = Mathf.Cos(input.y) * input.x;
            output.y = Mathf.Sin(input.y) * input.x;

            return output;
        }

        public static Vector2 AngularToCartesian(float magnitude, float angle) {
            Vector2 output = Vector2.one;

            output.x = Mathf.Cos(angle) * magnitude;
            output.y = Mathf.Sin(angle) * magnitude;

            return output;
        }
    }

}
