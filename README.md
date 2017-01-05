# mini-excel-c-sharp
A spreadsheet with a command-line interface. The spreadsheet is to be able to process cells that conatin either primitive values or expressions.
Each cell may contain:
- Nothing
- A positive integer
- Strings that begin with symbol `
- Expression lines, that begin with ‘=’ and incorporate positive integers, cell references, and simple arithmetic expressions. Parentheses are not allowed. All operations have an equal priority. Cell references consist of a Latin letter followed by a digit.

The grammar of a cell:
1) <expression> -> = <term> {(+|-|*|/) <term>}
2) <term> -> <cell_reference> | unsigned_integer
3) <cell_reference> -> [A-Za-z][0-9]
4) <text> -> '{symbol}

The program receives the description of a table from standard input. Then the table is evaluated and the obtained result is printed to standard output. The first line contains a pair of tab-separated numbers, which are the height and width of the table correspondingly. Lines that follow contain the table cells and are based on the above-mentioned grammar.

The output has to contain only expected information including error messages. There should not be any other information, including "welcome text". Output data is represented as a table where line elements are tab-separated. 