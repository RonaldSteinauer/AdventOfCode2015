using System.Windows;

namespace AdventOfCode2015.Days
{
    public class Day02
    {
        const string input = "29x13x26\r\n11x11x14\r\n27x2x5\r\n6x10x13\r\n15x19x10\r\n26x29x15\r\n8x23x6\r\n17x8x26\r\n20x28x3\r\n23x12x24\r\n11x17x3\r\n19x23x28\r\n25x2x25\r\n1x15x3\r\n25x14x4\r\n23x10x23\r\n29x19x7\r\n17x10x13\r\n26x30x4\r\n16x7x16\r\n7x5x27\r\n8x23x6\r\n2x20x2\r\n18x4x24\r\n30x2x26\r\n6x14x23\r\n10x23x9\r\n29x29x22\r\n1x21x14\r\n22x10x13\r\n10x12x10\r\n20x13x11\r\n12x2x14\r\n2x16x29\r\n27x18x26\r\n6x12x20\r\n18x17x8\r\n14x25x1\r\n30x15x22\r\n17x18x7\r\n28x23x24\r\n15x12x25\r\n14x7x20\r\n29x23x8\r\n24x5x22\r\n6x22x8\r\n1x15x26\r\n14x5x1\r\n24x28x28\r\n17x23x23\r\n4x15x7\r\n23x8x11\r\n6x15x1\r\n23x18x13\r\n17x1x26\r\n23x13x17\r\n2x18x8\r\n22x22x1\r\n10x22x6\r\n28x29x20\r\n22x21x25\r\n14x8x23\r\n12x30x14\r\n8x7x5\r\n3x30x15\r\n4x3x29\r\n25x18x3\r\n16x7x16\r\n4x3x8\r\n9x16x30\r\n20x28x3\r\n28x24x6\r\n4x18x2\r\n23x18x5\r\n22x4x30\r\n15x30x9\r\n7x12x12\r\n3x22x29\r\n12x1x9\r\n9x2x25\r\n17x11x10\r\n25x24x7\r\n7x27x26\r\n26x4x12\r\n29x2x26\r\n19x24x12\r\n23x23x3\r\n26x28x16\r\n18x4x16\r\n25x30x18\r\n29x19x19\r\n16x3x27\r\n29x25x29\r\n18x19x5\r\n14x21x30\r\n19x13x26\r\n19x10x15\r\n9x4x7\r\n18x6x6\r\n24x25x29\r\n9x12x27\r\n15x3x22\r\n30x17x21\r\n18x19x28\r\n9x11x12\r\n8x28x22\r\n11x3x4\r\n28x17x20\r\n24x18x15\r\n11x12x13\r\n6x19x24\r\n28x4x5\r\n28x22x23\r\n13x29x2\r\n9x16x15\r\n29x28x1\r\n10x18x30\r\n19x11x12\r\n26x28x25\r\n23x17x13\r\n25x1x21\r\n17x1x27\r\n17x27x28\r\n28x13x15\r\n14x13x25\r\n11x29x7\r\n22x29x5\r\n13x6x14\r\n23x18x13\r\n25x7x17\r\n18x9x20\r\n21x11x2\r\n28x11x13\r\n13x25x1\r\n19x29x25\r\n16x29x4\r\n10x21x10\r\n7x25x17\r\n5x9x3\r\n1x15x6\r\n8x27x29\r\n23x6x30\r\n22x22x29\r\n6x20x30\r\n26x25x29\r\n10x19x19\r\n20x30x9\r\n5x30x24\r\n17x10x27\r\n30x14x30\r\n8x17x4\r\n7x18x6\r\n3x5x4\r\n24x17x15\r\n14x20x17\r\n22x27x15\r\n18x14x15\r\n23x9x11\r\n21x16x29\r\n7x18x21\r\n9x3x29\r\n10x13x4\r\n2x30x4\r\n23x20x4\r\n8x22x21\r\n29x28x4\r\n13x16x25\r\n21x9x11\r\n7x26x26\r\n13x23x30\r\n19x7x10\r\n9x23x21\r\n21x9x17\r\n9x21x15\r\n20x29x22\r\n23x13x15\r\n19x25x2\r\n12x11x30\r\n20x21x6\r\n21x6x17\r\n24x26x9\r\n29x21x29\r\n29x26x16\r\n6x16x1\r\n2x12x6\r\n6x7x20\r\n7x2x22\r\n6x22x4\r\n13x11x27\r\n25x27x14\r\n11x8x6\r\n26x11x14\r\n30x3x29\r\n27x21x20\r\n15x16x26\r\n6x22x10\r\n11x9x25\r\n23x13x6\r\n13x9x3\r\n30x22x13\r\n29x23x14\r\n25x19x6\r\n7x29x11\r\n19x18x5\r\n29x25x13\r\n25x24x27\r\n1x9x12\r\n22x9x17\r\n14x12x28\r\n19x21x17\r\n13x25x17\r\n14x25x12\r\n4x14x30\r\n7x15x28\r\n3x6x25\r\n6x2x16\r\n15x19x11\r\n17x30x20\r\n20x23x7\r\n26x21x6\r\n26x29x24\r\n2x4x30\r\n4x22x18\r\n13x3x28\r\n27x6x21\r\n5x3x27\r\n12x7x11\r\n28x11x9\r\n12x9x2\r\n1x22x20\r\n15x13x28\r\n14x19x16\r\n28x20x3\r\n20x4x9\r\n26x7x26\r\n18x19x25\r\n7x1x13\r\n20x23x29\r\n27x26x8\r\n11x15x15\r\n10x21x23\r\n29x2x11\r\n21x28x20\r\n3x18x23\r\n26x17x17\r\n14x26x17\r\n20x7x17\r\n18x12x8\r\n4x8x8\r\n8x15x23\r\n24x29x5\r\n1x25x8\r\n1x28x17\r\n16x18x13\r\n29x24x22\r\n13x16x10\r\n14x7x16\r\n15x11x29\r\n12x15x19\r\n17x6x28\r\n4x3x9\r\n15x16x8\r\n29x27x11\r\n2x24x20\r\n4x21x3\r\n29x24x27\r\n18x22x22\r\n7x8x18\r\n20x7x8\r\n19x9x2\r\n20x17x2\r\n2x29x10\r\n19x25x1\r\n28x9x3\r\n29x27x20\r\n7x21x7\r\n10x4x22\r\n26x8x5\r\n26x14x1\r\n5x27x9\r\n2x18x3\r\n3x27x17\r\n30x17x23\r\n30x11x20\r\n4x6x7\r\n6x29x27\r\n30x16x20\r\n24x30x28\r\n19x20x26\r\n18x1x25\r\n26x12x12\r\n19x15x29\r\n16x21x24\r\n23x13x26\r\n25x16x10\r\n8x9x18\r\n24x14x1\r\n24x15x21\r\n19x9x14\r\n8x23x11\r\n22x2x16\r\n29x9x26\r\n3x16x25\r\n15x20x30\r\n3x11x12\r\n15x2x3\r\n13x7x4\r\n2x7x27\r\n9x26x11\r\n30x24x19\r\n28x17x21\r\n10x8x2\r\n11x15x26\r\n10x12x20\r\n24x24x27\r\n25x26x16\r\n13x4x20\r\n25x13x11\r\n12x22x3\r\n20x7x1\r\n12x18x6\r\n26x8x20\r\n14x2x7\r\n23x12x1\r\n26x24x24\r\n27x26x23\r\n26x17x5\r\n17x24x2\r\n26x5x6\r\n23x5x1\r\n5x18x30\r\n24x21x19\r\n5x28x11\r\n21x20x14\r\n25x4x22\r\n26x24x11\r\n7x5x8\r\n13x1x30\r\n5x1x6\r\n14x5x2\r\n8x11x7\r\n13x20x1\r\n17x30x14\r\n29x22x10\r\n12x26x3\r\n27x17x3\r\n26x27x4\r\n5x26x17\r\n22x11x19\r\n8x26x3\r\n24x19x22\r\n7x1x4\r\n6x27x30\r\n4x28x14\r\n16x14x18\r\n4x5x20\r\n19x25x4\r\n15x15x1\r\n10x14x14\r\n16x18x24\r\n21x27x15\r\n5x5x10\r\n1x7x13\r\n16x2x8\r\n13x15x11\r\n3x25x10\r\n20x29x8\r\n12x3x2\r\n10x13x12\r\n25x27x1\r\n11x30x19\r\n7x19x13\r\n27x6x18\r\n16x21x19\r\n21x29x5\r\n16x23x12\r\n29x19x15\r\n5x5x10\r\n27x15x1\r\n13x16x22\r\n29x19x5\r\n8x12x9\r\n3x18x5\r\n13x25x3\r\n5x9x21\r\n10x20x16\r\n9x9x11\r\n23x21x1\r\n22x2x15\r\n27x8x13\r\n23x7x3\r\n26x30x15\r\n29x15x16\r\n16x27x13\r\n2x18x9\r\n10x27x8\r\n20x9x25\r\n10x2x17\r\n16x13x13\r\n21x26x1\r\n27x26x24\r\n9x30x16\r\n19x17x28\r\n25x15x1\r\n10x26x6\r\n10x11x11\r\n5x26x25\r\n30x4x15\r\n9x8x23\r\n14x25x7\r\n8x28x8\r\n28x18x24\r\n4x4x25\r\n16x25x11\r\n17x27x8\r\n15x16x9\r\n24x13x21\r\n17x3x27\r\n27x5x26\r\n8x27x12\r\n29x2x8\r\n24x23x30\r\n1x30x21\r\n6x18x20\r\n13x14x12\r\n25x30x23\r\n24x6x24\r\n12x7x21\r\n11x6x8\r\n8x30x30\r\n26x3x12\r\n28x6x5\r\n18x7x1\r\n7x6x20\r\n14x16x18\r\n11x22x15\r\n4x20x10\r\n19x24x19\r\n8x24x11\r\n4x9x10\r\n6x6x22\r\n10x9x29\r\n1x5x28\r\n19x25x29\r\n20x30x3\r\n15x13x13\r\n9x9x24\r\n20x14x29\r\n26x24x13\r\n2x25x8\r\n10x26x2\r\n12x19x12\r\n18x6x20\r\n4x5x14\r\n26x27x10\r\n16x26x20\r\n3x21x15\r\n2x26x18\r\n14x11x17\r\n26x26x25\r\n10x1x11\r\n17x19x19\r\n27x28x26\r\n9x2x10\r\n19x30x15\r\n23x30x14\r\n15x3x20\r\n2x14x22\r\n21x18x8\r\n22x4x29\r\n19x6x29\r\n9x26x29\r\n16x10x9\r\n22x12x22\r\n13x28x14\r\n25x14x28\r\n28x3x30\r\n10x17x1\r\n10x27x22\r\n10x23x19\r\n14x25x9\r\n11x24x8\r\n30x25x10\r\n22x13x28\r\n2x7x6\r\n11x20x8\r\n9x22x14\r\n19x16x9\r\n11x24x4\r\n11x17x2\r\n6x4x10\r\n26x10x10\r\n12x14x5\r\n27x10x3\r\n15x3x6\r\n11x7x19\r\n22x10x12\r\n21x26x10\r\n13x20x3\r\n27x8x8\r\n1x24x23\r\n24x9x22\r\n23x17x23\r\n3x28x19\r\n2x20x28\r\n23x17x24\r\n26x1x4\r\n4x1x12\r\n5x6x16\r\n13x22x13\r\n25x21x21\r\n20x21x12\r\n9x24x25\r\n17x16x12\r\n12x28x9\r\n18x16x27\r\n29x12x2\r\n30x12x15\r\n24x11x10\r\n4x9x22\r\n4x24x5\r\n19x11x5\r\n6x25x6\r\n1x20x17\r\n22x8x21\r\n11x26x4\r\n16x19x3\r\n8x12x8\r\n13x2x18\r\n10x5x11\r\n8x12x17\r\n21x2x5\r\n26x17x26\r\n23x18x17\r\n28x11x14\r\n1x4x27\r\n29x5x28\r\n5x9x10\r\n5x7x25\r\n20x15x27\r\n15x11x17\r\n12x14x1\r\n29x14x4\r\n18x14x18\r\n14x25x24\r\n26x14x18\r\n13x8x11\r\n30x1x23\r\n3x4x12\r\n12x24x9\r\n8x6x16\r\n14x15x30\r\n12x30x8\r\n22x11x18\r\n16x30x28\r\n17x18x4\r\n13x14x23\r\n2x28x8\r\n3x28x30\r\n29x30x8\r\n4x6x26\r\n6x30x17\r\n11x30x30\r\n19x4x3\r\n12x15x20\r\n22x28x4\r\n26x30x2\r\n6x12x7\r\n1x10x5\r\n25x29x7\r\n17x9x18\r\n16x21x29\r\n21x14x7\r\n15x16x11\r\n26x6x15\r\n8x24x7\r\n2x20x4\r\n2x9x3\r\n19x8x13\r\n18x7x22\r\n27x14x17\r\n2x13x8\r\n18x15x26\r\n15x27x27\r\n18x11x15\r\n1x29x20\r\n21x12x11\r\n20x2x15\r\n28x23x9\r\n1x1x17\r\n7x23x9\r\n30x9x27\r\n9x16x18\r\n15x24x28\r\n30x11x18\r\n29x26x10\r\n9x5x25\r\n2x1x19\r\n14x3x14\r\n6x3x6\r\n30x15x20\r\n20x17x27\r\n28x10x9\r\n14x24x28\r\n17x11x6\r\n12x3x6\r\n8x8x15\r\n23x14x21\r\n11x21x7\r\n5x13x30\r\n4x29x25\r\n30x28x24\r\n18x4x9\r\n3x15x6\r\n13x9x19\r\n30x14x7\r\n7x9x9\r\n17x11x26\r\n24x26x13\r\n16x21x16\r\n27x17x25\r\n2x21x11\r\n9x11x27\r\n3x3x7\r\n13x8x14\r\n20x20x26\r\n13x29x22\r\n30x11x1\r\n7x10x19\r\n27x5x9\r\n23x17x15\r\n21x6x13\r\n24x15x16\r\n18x4x14\r\n18x16x6\r\n22x11x18\r\n14x2x5\r\n15x3x7\r\n10x20x29\r\n16x1x10\r\n30x23x1\r\n10x15x11\r\n17x14x5\r\n22x8x13\r\n7x11x28\r\n26x17x3\r\n2x23x2\r\n28x13x19\r\n18x12x28\r\n22x23x16\r\n14x12x1\r\n20x8x19\r\n17x19x13\r\n29x2x12\r\n2x26x27\r\n29x16x4\r\n13x8x18\r\n16x15x30\r\n23x16x2\r\n28x8x27\r\n21x8x23\r\n13x20x26\r\n19x6x17\r\n17x30x15\r\n7x4x30\r\n2x13x30\r\n18x7x19\r\n4x13x27\r\n8x6x5\r\n18x20x25\r\n2x3x30\r\n23x27x13\r\n22x30x4\r\n23x25x25\r\n23x16x19\r\n25x3x1\r\n5x6x15\r\n11x29x12\r\n25x24x7\r\n16x7x20\r\n20x3x2\r\n12x27x15\r\n16x10x12\r\n1x3x14\r\n22x1x26\r\n2x24x18\r\n11x29x16\r\n15x2x9\r\n10x1x24\r\n21x8x11\r\n30x11x23\r\n6x30x21\r\n13x27x29\r\n14x6x5\r\n18x29x19\r\n12x4x28\r\n29x3x14\r\n10x30x28\r\n5x7x15\r\n14x1x10\r\n9x25x14\r\n7x24x18\r\n28x17x21\r\n18x13x25\r\n26x15x1\r\n21x1x19\r\n12x16x21\r\n4x6x13\r\n7x15x26\r\n17x19x5\r\n12x28x2\r\n1x20x19\r\n27x7x5\r\n17x26x8\r\n12x15x19\r\n5x23x10\r\n8x2x8\r\n16x13x12\r\n14x27x1\r\n26x29x3\r\n24x16x14\r\n14x13x13\r\n7x22x23\r\n2x9x30\r\n4x27x8\r\n26x27x15\r\n23x1x6\r\n25x29x18\r\n5x18x1\r\n20x8x20\r\n5x10x25\r\n30x25x15\r\n7x22x25\r\n28x26x17\r\n29x4x1\r\n21x11x27\r\n20x9x8\r\n25x22x12\r\n2x11x11\r\n23x2x16\r\n23x27x20\r\n2x13x28\r\n27x2x24\r\n11x1x17\r\n12x4x27\r\n16x20x22\r\n30x12x10\r\n5x15x4\r\n5x2x27\r\n12x4x25\r\n1x16x4\r\n27x4x4\r\n21x16x3\r\n27x26x3\r\n24x6x6\r\n24x12x12\r\n20x20x25\r\n8x29x2\r\n21x4x5\r\n2x4x8\r\n4x13x19\r\n3x20x10\r\n12x15x16\r\n6x5x4\r\n12x16x20\r\n22x19x17\r\n8x17x22\r\n25x16x15\r\n7x1x19\r\n10x1x7\r\n23x23x5\r\n28x6x12\r\n2x25x12\r\n10x27x12\r\n24x27x19\r\n14x14x20\r\n4x1x5\r\n16x27x29\r\n20x20x24\r\n28x24x30\r\n6x15x15\r\n9x15x30\r\n23x26x3\r\n17x24x21\r\n22x25x25\r\n18x29x10\r\n20x25x1\r\n24x11x16\r\n20x7x21\r\n20x7x9\r\n7x26x2\r\n5x18x1\r\n16x26x28\r\n4x10x18\r\n27x30x21\r\n26x9x9\r\n8x16x14\r\n6x27x8\r\n28x9x20\r\n13x13x4\r\n9x18x16\r\n18x15x18\r\n22x19x14\r\n14x10x17\r\n25x29x11\r\n1x18x19\r\n8x11x26\r\n18x6x14\r\n30x24x13\r\n27x1x27\r\n15x9x3\r\n2x29x17\r\n2x26x21\r\n22x9x9\r\n20x20x20\r\n22x28x2\r\n26x5x16\r\n11x3x14\r\n21x16x16\r\n18x26x7\r\n18x30x6\r\n7x11x12\r\n15x10x2\r\n27x2x16\r\n27x30x24\r\n28x14x24\r\n7x4x8\r\n6x28x15\r\n13x19x1\r\n22x26x30\r\n7x30x24\r\n2x17x21\r\n19x26x2\r\n19x24x15\r\n14x23x2\r\n21x27x15\r\n30x15x14\r\n21x29x5\r\n23x30x2\r\n4x1x2\r\n15x5x13\r\n21x2x30\r\n20x7x16\r\n1x21x25\r\n2x25x1\r\n12x29x5\r\n28x13x16\r\n26x3x12\r\n29x20x23\r\n28x12x20\r\n4x30x8\r\n16x15x16\r\n6x16x29\r\n2x28x13\r\n24x25x2\r\n26x15x22\r\n17x20x11\r\n18x12x7\r\n19x1x18\r\n8x27x13\r\n22x16x8\r\n19x26x17\r\n13x11x10\r\n22x12x3\r\n13x12x14\r\n29x17x9\r\n6x14x10\r\n14x20x10\r\n8x26x9\r\n25x13x22\r\n3x30x25\r\n14x28x1\r\n30x29x12\r\n3x17x15\r\n3x24x14\r\n28x24x22\r\n16x6x1\r\n20x25x14\r\n17x17x13\r\n6x19x27\r\n10x15x20\r\n8x23x20\r\n7x29x21\r\n18x9x25\r\n10x5x22\r\n2x27x27\r\n16x18x30\r\n15x5x12\r\n26x29x29\r\n28x11x10\r\n9x29x28\r\n24x15x23\r\n26x9x10\r\n5x1x25\r\n22x27x16\r\n7x29x3\r\n1x3x5\r\n8x7x29\r\n19x21x11\r\n28x13x30\r\n17x16x20\r\n5x10x25\r\n9x14x15\r\n15x14x23\r\n16x4x17\r\n21x8x2\r\n9x9x8\r\n22x22x4\r\n10x2x27\r\n12x19x10\r\n15x29x4\r\n22x14x7\r\n29x18x5\r\n1x7x27\r\n24x1x15\r\n23x23x26\r\n12x17x23\r\n26x10x24\r\n8x22x2\r\n8x1x10\r\n22x19x12\r\n2x23x13\r\n11x27x25\r\n26x15x27\r\n27x7x21\r\n18x9x6\r\n22x21x22\r\n7x12x26\r\n23x21x13\r\n14x3x8\r\n5x9x28\r\n29x29x15\r\n27x25x23\r\n12x2x24\r\n8x2x20\r\n29x19x4\r\n12x24x29\r\n2x27x28\r\n14x20x9\r\n28x6x25\r\n18x29x8\r\n19x11x30\r\n15x11x23\r\n18x7x7\r\n14x20x14\r\n26x18x22\r\n27x25x13\r\n12x10x30\r\n30x2x7\r\n28x10x1\r\n18x10x30\r\n22x11x5\r\n22x16x3\r\n25x15x9\r\n5x10x24\r\n4x28x8\r\n19x24x18\r\n3x4x25\r\n14x4x30\r\n11x26x3\r\n12x12x12\r\n26x7x24\r\n3x2x14\r\n1x27x7\r\n2x2x13\r\n3x26x26\r\n12x4x11\r\n12x17x20\r\n4x19x30\r\n5x18x10\r\n17x6x18\r\n19x30x20\r\n11x2x17\r\n30x13x19\r\n22x23x7\r\n17x28x2\r\n5x17x30\r\n7x11x4\r\n21x26x18\r\n15x28x4\r\n5x6x27\r\n12x6x16\r\n9x17x12\r\n27x20x5\r\n14x5x20\r\n27x14x6\r\n2x14x21\r\n4x28x30\r\n24x5x1\r\n19x29x29\r\n11x23x1\r\n8x16x21\r\n3x17x19\r\n10x13x5\r\n20x21x16\r\n23x3x6\r\n27x26x11\r\n3x2x22\r\n14x3x5\r\n10x9x8";

        public Day02()
        {
            var result = Stage2();

            Console.WriteLine(result);

            Clipboard.SetText(result);
        }

        private string Stage1()
        {
            return GetPackages().Select(d => d.GetArea()).Sum().ToString();
        }

        private string Stage2()
        {
            return GetPackages().Select(d => d.GetRibbon()).Sum().ToString();
        }

        private List<Package> GetPackages()
        {
            return input.Split("\r\n").Select(d => new Package(d)).ToList();
        }
    }

    public class Package
    {
        public Package(string dimension)
        {
            var dimensions = dimension.Split("x").Select(d => int.Parse(d)).OrderBy(d => d).ToList();

            l = dimensions[0];
            w = dimensions[1];
            h = dimensions[2];
        }

        public int l { get; set; }

        public int h { get; set; }

        public int w { get; set; }

        public int GetArea()
        {
            return 2 * l * w + 2 * w * h + 2 * h * l + l * w;
        }

        public int GetRibbon()
        {
            var bow = l * h * w;
            var ribbon = 2 * l + 2 * w;

            return ribbon + bow;
        }
    }
}
