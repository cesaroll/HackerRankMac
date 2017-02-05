ing System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        var input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        var N = input[0];
        var Q = input[1];
        
        List<int>[] seqs = new List<int>[N];
        
        for(int i=0; i<N; i++) {
            seqs[i] = new List<int>();
        }
        
        var lastAns = 0;
        
        while(Q-- > 0) {
            input = Console.ReadLine().Split(' ').Select(r => int.Parse(r)).ToArray();
            
            var op = input[0];
            var x = input[1];
            var y = input[2];
            
            int seqIdx = (x^lastAns) % N;
            
            if(op == 1) {
                seqs[seqIdx].Add(y);
                //Console.WriteLine("{0} - {1}", idx,y);
            } else if(op == 2) {
                int elmtIdx = y % seqs[seqIdx].Count();
                //Console.WriteLine("x: {0}, y: {1}", x, y);
                //Console.WriteLine("seqIdx: {0}, elmtIdx: {1}, seqSize: {2}", seqIdx, elmtIdx, seqs[seqIdx].Count());
                lastAns = seqs[seqIdx][elmtIdx];
                Console.WriteLine(lastAns);
            }
            
        }
        
    }
}
