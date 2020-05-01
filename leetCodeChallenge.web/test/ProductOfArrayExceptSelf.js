/**
 * @param {number[]} nums
 * @return {number[]}
 */
var productExceptSelf = function (nums) {
    var ac1;
    var ac2;
    var result1 = [];
    var i = 0;
    while (i < nums.length) {
        var previews1 = nums[i - 1] !== undefined ? nums[i - 1] : 1;
        ac1 = (ac1 !== undefined ? ac1 : 1) * previews1;
        result1.push(ac1);

        i++;
    }
    var result = [];
    var j = nums.length - 1;
    while (j >= 0){
        var preview2 = nums[j + 1] !== undefined ? nums[j + 1] : 1;
        ac2 = (ac2 !== undefined ? ac2 : 1) * preview2;
        result.unshift(result1[j] * ac2);
        j--;
    }
    return result;
}
// ;var productExceptSelf = function (nums) {
//     var i = 0;
//     var j = nums.length - 1;
//     var ac1;
//     var ac2;
//     var result1 = [];
//     var result2 = [];
//     while (i < nums.length) {
//         var previews1 = nums[i - 1] !== undefined ? nums[i - 1] : 1;
//         ac1 = (ac1 !== undefined ? ac1 : 1) * previews1;
//         result1.push(ac1);
//
//         var preview2 = nums[j + 1] !== undefined ? nums[j + 1] : 1;
//         ac2 = (ac2 !== undefined ? ac2 : 1) * preview2;
//         result2.unshift(ac2);
//
//         i++;
//         j--;
//     }
//
//     var result = [];
//     for (var k = 0; k < nums.length; k++) {
//         result.push(result1[k] * result2[k]);
//     }
//     return result;
// };

var assert = !assert ? require('assert') : assert;
describe('Product of array except self ', function () {

    it('Case 1', function () {
        var nums = [1, 2, 3, 4];

        var result = productExceptSelf(nums);

        assert.equal(result.toString(), [24, 12, 8, 6].toString());
    });
    it('Case 2', function () {
        var nums = [1, 2, 3, 4, 1, 2, 0, 1, 2, 3, 5];

        var result = productExceptSelf(nums);

        assert.equal(result.toString(), [0, 0, 0, 0, 0, 0, 1440, 0, 0, 0, 0].toString());
    });
    it('Case 3', function () {
        var nums = [0, 0];

        var result = productExceptSelf(nums);

        assert.equal(result.toString(), [[0, 0]].toString());
    });
    it('Case 4: zeros', function () {
        var nums = [0, 2, 3, 4,1, 2, 0, 1, 2, 3, 5];

        var result = productExceptSelf(nums);

        assert.equal(result.toString(), [0,0,0,0,0,0,0,0,0,0,0].toString());
    });
    it('Case 5: large', function () {
        var nums = [1, 2, 3, 4, 1, 2, 2, 1, 2, 3, 5,1, 2, 3, 4, 1, 2, 2, 1, 2, 3, 5];

        var result = productExceptSelf(nums);

        assert.equal(result.toString(), [8294400,4147200,2764800,2073600,8294400,4147200,4147200,8294400,4147200,2764800,1658880,8294400,4147200,2764800,2073600,8294400,4147200,4147200,8294400,4147200,2764800,1658880].toString());
    });
});
