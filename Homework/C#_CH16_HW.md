### -- Dawid Perkowski

### --File: C#_CH16_HW

1. Give five examples (using valid C# code) of the five bitwise operators listed in the text.

   - The Not(~) Operator, The Left-shift (<<) Operator, The OR (|) Operator, The AND (&) Operator, The XOR (^) Operator
2. Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valie C# code.
- Yes it does. uint x = 0b_1001; Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2), 4}"); uint y = x >> 2; Console.WriteLine($"After: {Convert.ToString(y, toBase: 2), 4}");
3. Explain in detail this code: bits & (1 << index);

   -   Expression uses the left-shift (<<) and bitwise AND (&) operators to determine whether the sixth bit from the right of the byte variable named bits is set to 0 or to 1
4. Explain in detail this code: bits |= (1 << index);.

   - If you want to set the bit at position index to 1, you can use the bitwise OR (|) operator.
5.  Explain in detail this code: bits &= (1 << index);.

   - Uses the compound assignment operator &= to set the bit at position index to 0
   
7. How does C# interpret this? bool peek = bits[n];

   -  Boolean value true is synonymous with the binary value 1, and the Boolean value false is synonymous with the binary value 0.
7. . How does C# interpret this? bits[n] = true;
   - “Set the bit x number of places from the right of the bits variable to 1.”
8. How does C# interpret this? bits[n] ^= true;
   - XOR operator (^) to invert the value of the bit at index 6 in the bits variable
9. Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4. How would you interpret the following user permissions:
   - (A) No permissions (B) Read (C) Write (E) Execute (D, f, g, h) No Permissions
10. Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this shceme of permissions?
   - 0b0_0001 0b0_0010 0b0_0100 0b0_1000 0b0_0111 0b0_0011 0b0_1001 0b0_1101
