/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function (nums, target) {
    var num = nums.indexOf(target)
    return num;
};

var assert = !assert ? require('assert') : assert;
describe('ContiguosnArray', function () {
    it('Case 1: minimun length', function () {
        var nums = [4,5,6,7,0,1,2], target = 0

        var result = search(nums, target);

        assert.equal(result, 4);
    });
});
