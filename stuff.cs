using System.Numerics;
using System.Security.Cryptography;

namespace vlutil {
    public struct vec2 {
        public float x, y;

        public vec2(float x, float y) { this.x = x; this.y = y; }
        public vec2(float a) { x = a; y = a; }
        public vec2() { }

        public static vec2 zero = new vec2(0);
        public static vec2 one = new vec2(1);

        public static vec2 operator *(vec2 v, float n) => new vec2(v.x * n, v.y * n);
        public static vec2 operator *(vec2 v, vec2 n) => new vec2(v.x * n.x, v.y * n.y);
        public static vec2 operator *(float n, vec2 v) => v * n;
        public static vec2 operator /(vec2 v, float n) => new vec2(v.x / n, v.y / n);
        public static vec2 operator /(vec2 v, vec2 n) => new vec2(v.x / n.x, v.y / n.y);
        public static vec2 operator /(float n, vec2 v) => new vec2(n / v.x, n / v.y);
        public static vec2 operator +(vec2 v, vec2 n) => new vec2(v.x + n.x, v.y + n.y);
        public static vec2 operator +(vec2 v, float n) => new vec2(v.x + n, v.y + n);
        public static vec2 operator +(float n, vec2 v) => v + n;
        public static vec2 operator -(vec2 v, float n) => v + -n;
        public static vec2 operator -(vec2 v) => new vec2(-v.x, -v.y);
        public static vec2 operator -(float n, vec2 v) => n + -v;
        public static vec2 operator -(vec2 v, vec2 n) => v + -n;
        public static vec2 operator %(vec2 v, vec2 n) => new vec2(v.x % n.x, v.y % n.y);
        public static vec2 operator %(vec2 v, float n) => v % new vec2(n);
        public static bool operator ==(vec2 v, vec2 n) => v.x == n.x && v.y == n.y;
        public static bool operator !=(vec2 v, vec2 n) => v.x != n.x || v.y != n.y;
        public static bool operator >(vec2 v, vec2 n) => v.x > n.x && v.x > n.y;
        public static bool operator <(vec2 v, vec2 n) => n > v;
        public static bool operator >=(vec2 v, vec2 n) => v.x >= n.x && v.y >= n.y;
        public static bool operator <=(vec2 v, vec2 n) => n >= v;

        public Vector2 conv() => new Vector2(x, y);
    }

    /*public struct vec3 {
        public float x, y, z;

        public vec3(float x, float y) { this.x = x; this.y = y; }
        public vec3(float a) { x = a; y = a; }
        public vec3(float x, float y, float z) { this.x = x; this.y = y; this.z = z; }
        public vec3() { }

        public static vec3 zero = new vec3(0);
        public static vec3 one = new vec3(1);

        public static vec3 operator *(vec2 v, float n) => new vec2(v.x * n, v.y * n);
        public static vec3 operator *(vec2 v, vec2 n) => new vec2(v.x * n.x, v.y * n.y);
        public static vec3 operator *(float n, vec2 v) => v * n;
        public static vec3 operator /(vec2 v, float n) => new vec2(v.x / n, v.y / n);
        public static vec3 operator /(vec2 v, vec2 n) => new vec2(v.x / n.x, v.y / n.y);
        public static vec3 operator /(float n, vec2 v) => new vec2(n / v.x, n / v.y);
        public static vec3 operator +(vec2 v, vec2 n) => new vec2(v.x + n.x, v.y + n.y);
        public static vec3 operator +(vec2 v, float n) => new vec2(v.x + n, v.y + n);
        public static vec3 operator +(float n, vec2 v) => v + n;
        public static vec3 operator -(vec2 v, float n) => v + -n;
        public static vec3 operator -(vec2 v) => new vec2(-v.x, -v.y);
        public static vec3 operator -(float n, vec2 v) => n + -v;
        public static vec3 operator -(vec2 v, vec2 n) => v + -n;
        public static vec3 operator %(vec2 v, vec2 n) => new vec2(v.x % n.x, v.y % n.y);
        public static vec3 operator %(vec2 v, float n) => v % new vec2(n);

        public Vector2 conv() => new Vector2(x, y);
    }*/

    public class m { //math
        static Random r = new Random();

        //random
        public static float rand() => (float)r.NextDouble();
        public static float rand(int min, int max) => r.Next(min, max);
        public static float rand(float min, float max) => ((float)r.NextDouble() + min) * (max - min);

        //values
        public static float pi = 3.14159265358979323846264338327950288420f;
        public static float e = 2.718281828459045235360287471352662497757f;

        //misc values
        public static float v180dpi = 57.295779513082320876798154814105170417f;
        public static float vpid180 = 0.0174532925199432957692369076848861271344f;

        //radians and degrees
        public static float r2d(float a) => v180dpi * a;
        public static float d2r(float a) => vpid180 * a;

        //trig
        public static float sin(float a) => MathF.Sin(a);
        public static float cos(float a) => MathF.Cos(a);
        public static float tan(float a) => MathF.Tan(a);
        public static float cot(float a) => 1 / MathF.Tan(a);
        public static float sec(float a) => 1 / MathF.Cos(a);
        public static float csc(float a) => 1 / MathF.Sin(a);
        public static float atan(float a) => MathF.Atan(a);
        public static float atan2(float y, float x) => MathF.Atan2(y, x);
        public static float acot(float a) => MathF.Atan(1 / a);
        public static float asec(float a) => MathF.Acos(1 / a);
        public static float acsc(float a) => MathF.Asin(1 / a);
        public static float asin(float a) => MathF.Asin(a);
        public static float acos(float a) => MathF.Acos(a);
        public static float tanh(float a) => MathF.Tanh(a);
        public static float sinh(float a) => MathF.Sinh(a);
        public static float cosh(float a) => MathF.Cosh(a);
        public static float coth(float a) => MathF.Cosh(a)/MathF.Sinh(a);
        public static float sech(float a) => 1 / MathF.Cosh(a);
        public static float csch(float a) => 1 / MathF.Sinh(a);
        public static float atanh(float a) => MathF.Atanh(a);
        public static float asinh(float a) => MathF.Asinh(a);
        public static float acosh(float a) => MathF.Acosh(a);
        public static float acoth(float a) => MathF.Atanh(1 / a);
        public static float asech(float a) => MathF.Acosh(1 / a);
        public static float acsch(float a) => MathF.Asinh(1 / a);

        //misc
        public static float abs(float a) => MathF.Abs(a);
        public static float flr(float a) => MathF.Floor(a);
        public static float ceil(float a) => MathF.Ceiling(a);
        public static float rnd(float a) => MathF.Round(a);
        public static float log(float a) => MathF.Log(a);
        public static float clmp(float n, float min, float max) => (float)Math.Clamp(n, min, max);

        //exponents and roots
        public static float pow(float n, float p) => MathF.Pow(n, p);
        public static float sqr(float a) => a * a;
        public static float cbe(float a) => a * a * a;
        public static float qrt(float a) => a * a * a * a;
        public static float qin(float a) => a * a * a * a * a;
        public static float root(float n, float r) => pow(n, 1/r);
        public static float sqrt(float a) => MathF.Sqrt(a);
        public static float cbrt(float a) => MathF.Cbrt(a);
        public static float qrtt(float a) => MathF.Pow(a, 0.25f);
        public static float qint(float a) => MathF.Pow(a, 0.2f);

        //geometry
        public static float dist(float a, float b) => abs(a - b);
        public static float dist(vec2 a, vec2 b) => sqrt(sqr(b.x - a.x) + sqr(b.y - a.y));
        public static float dirb(vec2 a, vec2 b) => atan2(b.y - a.y, b.x - a.x);
    }

    public class e { //easings
        static float 
            c1 = 1.70158f,
            c2 = 2.70158f,
            c3 = 2.5949095f,
            c4 = 3.5949095f,
            c5 = 2.09439510239319542564176225551966858947f,
            c6 = 1.39626340159546357643464573390622350408f;

        public static float isin(float x) => 1 - m.cos(x * m.pi / 2);
        public static float osin(float x) => m.sin(x * m.pi / 2);
        public static float iosin(float x) => -(m.cos(m.pi * x) - 1) / 2;

        public static float isqr(float x) => m.sqr(x);
        public static float osqr(float x) => 1 - m.sqr(1 - x);
        public static float iosqr(float x) => x < .5f ? 2 * m.sqr(x) : 1 - m.sqr(-2 * x + 2) / 2;

        public static float icbe(float x) => m.cbe(x);
        public static float ocbe(float x) => 1 - m.cbe(1 - x);
        public static float iocbe(float x) => x < .5f ? 4 * m.cbe(x) : 1 - m.cbe(-2 * x + 2) / 2;

        public static float iqrt(float x) => m.qrt(x);
        public static float oqrt(float x) => 1 - m.qrt(1 - x);
        public static float ioqrt(float x) => x < .5f ? 8 * m.qrt(x) : 1 - m.qrt(-2 * x + 2) / 2;

        public static float iqin(float x) => m.qin(x);
        public static float oqin(float x) => 1 - m.qin(1 - x);
        public static float ioqin(float x) => x < .5f ? 8 * m.qin(x) : 1 - m.qin(-2 * x + 2) / 2;

        public static float iexp(float x) => x == 0 ? 0 : m.pow(2, 10 * x - 10);
        public static float oexp(float x) => x == 1 ? 1 : 1 - m.pow(2, -10 * x);
        public static float ioexp(float x) => x == 0 ? 0 : x == 1 ? 1 : x < 0.5 ? m.pow(2, 20 * x - 10) / 2 : (2 - m.pow(2, -20 * x + 10)) / 2;

        public static float icir(float x) => 1 - m.sqrt(1 - m.sqr(x));
        public static float ocir(float x) => m.sqrt(1-m.sqr(x-1));
        public static float iocir(float x) => x < 0.5 ? (1 - m.sqrt(1 - m.sqr(2 * x))) / 2 : (m.sqrt(1 - m.sqr(-2 * x + 2)) + 1) / 2;

        public static float iback(float x) => c2 * m.cbe(x) - c1 * m.sqr(x);
        public static float oback(float x) => 1 + c2 * m.cbe(x - 1) + c1 * m.sqr(x - 1);
        public static float ioback(float x) => x < 0.5f ? (m.sqr(2 * x) * (c4 * 2 * x - c3)) / 2 : (m.sqr(2 * x - 2) * (c4 * (x * 2 - 2) + c3) + 2) / 2;

        public static float ielas(float x) => x == 0 ? 0 : x == 1 ? 1 : -m.pow(2, 10 * x - 10) * m.sin((x * 10 - 10.75f) * c5);
        public static float oelas(float x) => x == 0 ? 0 : x == 1 ? 1 : m.pow(2, -10 * x) * m.sin((x * 10 - .75f) * c5) + 1;
        public static float ioelas(float x) => x == 0 ? 0 : x == 1 ? 1 : x < .5f ? -(m.pow(2, 20 * x - 10) * m.sin((20 * x - 11.125f) * c6)) / 2 : m.pow(2, -20 * x + 10) * m.sin((20 * x - 11.125f) * c6) / 2 + 1;

        public static float iboun(float x) => 1 - oboun(1 - x);
        public static float oboun(float x) {
            if (x < 1 / 2.75f)
                return 7.5625f * x * x;
            else if (x < 2 / 2.75f)
                return 7.5625f * (x -= 1.5f / 2.75f) * x + 0.75f;
            else if (x < 2.5 / 2.75)
                return 7.5625f * (x -= 2.25f / 2.75f) * x + 0.9375f;
            else
                return 7.5625f * (x -= 2.625f / 2.75f) * x + 0.984375f;
        }
        public static float ioboun(float x) => x < .5f ? (1 - oboun(1 - 2 * x)) / 2 : (1 + oboun(2 * x - 1)) / 2;
    }

    public class c {
        public bool pospos(vec2 p1, vec2 p2) => p1 == p2;

        public bool lineline(line l1, line l2) {
            float uA = ((l2.p2.x - l2.p1.x) * (l1.p1.y - l2.p1.y) - (l2.p2.y - l2.p1.y) * (l1.p1.x - l2.p1.x)) / ((l2.p2.y - l2.p1.y) * (l1.p2.x - l1.p1.x) - (l2.p2.x - l2.p1.x) * (l1.p2.y - l1.p1.y));
            float uB = ((l1.p2.x - l1.p1.x) * (l1.p1.y - l2.p2.y) - (l1.p2.y - l1.p1.y) * (l1.p1.x - l2.p1.x)) / ((l2.p2.y - l2.p1.y) * (l1.p2.x - l1.p1.x) - (l2.p2.x - l2.p1.x) * (l1.p2.y - l1.p1.y));

            if (uA >= 0 && uA <= 1 && uB >= 0 && uB <= 1)
                return true;
            return false;
        }

        public bool linelinei(line l1, line l2, out vec2 ipoint) {
            float uA = ((l2.p2.x - l2.p1.x) * (l1.p1.y - l2.p1.y) - (l2.p2.y - l2.p1.y) * (l1.p1.x - l2.p1.x)) / ((l2.p2.y - l2.p1.y) * (l1.p2.x - l1.p1.x) - (l2.p2.x - l2.p1.x) * (l1.p2.y - l1.p1.y));
            float uB = ((l1.p2.x - l1.p1.x) * (l1.p1.y - l2.p2.y) - (l1.p2.y - l1.p1.y) * (l1.p1.x - l2.p1.x)) / ((l2.p2.y - l2.p1.y) * (l1.p2.x - l1.p1.x) - (l2.p2.x - l2.p1.x) * (l1.p2.y - l1.p1.y));

            if (uA >= 0 && uA <= 1 && uB >= 0 && uB <= 1) {
                float ix = l1.p1.x + (uA * (l1.p2.x - l1.p1.x));
                float iy = l1.p1.y + (uA * (l1.p2.y - l1.p1.y));
                ipoint = new vec2(ix, iy);

                return true;
            }
            ipoint = vec2.zero;
            return false;
        }

        public bool rectrect(rect r1, rect r2) => r1.p + r1.s >= r2.p && r1.p <= r2.p + r2.s;
        public bool rectcrectc(rect r1, rect r2) => r1.p + r1.s/2 >= r2.p - r2.s/2 && r1.p - r1.s/2 <= r2.p + r2.s/2;
        public bool rectcrect(rect r1, rect r2) => r1.p + r1.s / 2 >= r2.p && r1.p - r1.s / 2 <= r2.p + r2.s;
        public bool rectrectc(rect r1, rect r2) => rectcrect(r2, r1);

        public bool rectpos(rect r, vec2 p) => p >= r.p && p <= r.p + r.s;
        public bool rectcpos(rect r, vec2 p) => p >= r.p - r.s/2 && p <= r.p + r.s/2;

        public bool circpos(circ c, vec2 p) => m.dist(c.p, p) <= c.r;
        public bool circcirc(circ c1, circ c2) => m.dist(c1.p, c2.p) <= c1.r + c2.r;
    }

    public struct line {
        public vec2 p1;
        public vec2 p2;

        public line(vec2 p1, vec2 p2) { this.p1 = p1; this.p2 = p2; }
    }

    public struct rect {
        public vec2 p;
        public vec2 s;

        public rect(vec2 p, vec2 s) { this.p = p; this.s = s; }
    }

    public struct circ {
        public vec2 p;
        public float r;

        public circ(vec2 p, float r) { this.p = p; this.r = r; }
    }
}