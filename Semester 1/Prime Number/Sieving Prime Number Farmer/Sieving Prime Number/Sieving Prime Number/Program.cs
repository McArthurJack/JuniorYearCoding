﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sieving_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double limit = 1000000000;

// set of wheel "hit" positions for a 2/3/5 wheel rolled twice as per the Atkin algorithm
            //s ← { 1,7,11,13,17,19,23,29,31,37,41,43,47,49,53,59}
            List<int> hit = new List<int>() { 1, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 49, 53, 59 };

            // Initialize the sieve with enough wheels to include limit:
            for n ← 60 × w + x where w ∈ { 0,1,...,limit ÷ 60}, x ∈ s:
            is_prime(n) ← false

            for (int n = 60; )
            {

            }
// Put in candidate primes:
//   integers which have an odd number of
//   representations by certain quadratic forms.
// Algorithm step 3.1:
            for n ≤ limit, n ← 4x²+y² where x ∈ { 1,2,...}
            and y ∈ { 1,3,...} // all x's odd y's
            if n mod 60 ∈ { 1,13,17,29,37,41,49,53}:
        is_prime(n) ← ¬is_prime(n)   // toggle state
// Algorithm step 3.2:
for n ≤ limit, n ← 3x²+y² where x ∈ { 1,3,...}
            and y ∈ { 2,4,...} // only odd x's
            if n mod 60 ∈ { 7,19,31,43}:                                 // and even y's
        is_prime(n) ← ¬is_prime(n)   // toggle state
// Algorithm step 3.3:
for n ≤ limit, n ← 3x²-y² where x ∈ { 2,3,...}
            and y ∈ { x - 1,x - 3,...,1} //all even/odd
            if n mod 60 ∈ { 11,23,47,59}:                                   // odd/even combos
        is_prime(n) ← ¬is_prime(n)   // toggle state

// Eliminate composites by sieving, only for those occurrences on the wheel:
            for n² ≤ limit, n ← 60 × w + x where w ∈ { 0,1,...}, x ∈ s, n ≥ 7:
    if is_prime(n):
        // n is prime, omit multiples of its square; this is sufficient 
        // because square-free composites can't get on this list
        for c ≤ limit, c ← n² × (60 × w + x) where w ∈ { 0,1,...}, x ∈ s:
            is_prime(c) ← false

// one sweep to produce a sequential list of primes up to limit:
            output 2, 3, 5
for 7 ≤ n ≤ limit, n ← 60 × w + x where w ∈ { 0,1,...}, x ∈ s:
            if is_prime(n): output n
        }
    }
}
