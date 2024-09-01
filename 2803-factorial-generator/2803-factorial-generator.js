/**
 * @param {number} n
 * @yields {number}
 */
function* factorial(n) {
    const memo = new Map();

    function fact(n) {
        if(memo.has(n))
            return memo.get(n)

        let res;
        if(n <= 1)
            res = 1;
        else
            res = n * fact(n - 1);
        memo.set(n, res);
        return res;
    }

    if(n == 0)
        yield 1;
    else
    {
        for(let i = 1; i <= n; i++)
            yield fact(i);
    }
};

/**
 * const gen = factorial(2);
 * gen.next().value; // 1
 * gen.next().value; // 2
 */