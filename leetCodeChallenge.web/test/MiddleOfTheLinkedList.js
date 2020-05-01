var assert =  !assert ? require('assert') : assert;

function ListNode(val) {
    this.val = val;
    this.next = null;
    this.toArray = function () {
        var head = this;
        var list = [];
        while (head != null) {
            list.push(head.val);
            head = head.next
        }
        return list;
    }
}

/**
 * @param {ListNode} head
 * @return {ListNode}
 */
var middleNode = function (head) {
    var numMiddleNode = Math.floor(getCount(head) / 2) + 1;
    var count = 0;
    while (head != null) {
        count++;
        if (numMiddleNode === count)
            return head;
        head = head.next;
    }
};

function getCount(head) {
    var count = 0;
    while (head != null) {
        count++;
        head = head.next;
    }
    return count;
}

var arrayToLinkedList = function (nodes) {
    nodes = nodes.reverse();
    var head;
    for (var i = 0; i < nodes.length; i++) {
        if (i === 0) {
            head = new ListNode(nodes[i]);
        } else {
            var newNode = new ListNode(nodes[i]);
            newNode.next = head;
            head = newNode;
        }
    }
    return head;
};

describe('Middle of the Linked List ', function () {
    it('Case 1: input [1,2,3,4,5] Assert: Node 3 from this list (Serialization: [3,4,5])', function () {
        var nodes = [1, 2, 3, 4, 5];
        var head = arrayToLinkedList(nodes);

        var result = middleNode(head);

        assert.equal(result.val, 3);
        assert.equal(result.toArray().toString(), [3, 4, 5].toString());
    });

    it('Case 2: input [1,2,3,4,5,6,7] Assert: Node 4 from this list (Serialization: [4,5,6,7])', function () {
        var nodes = [1, 2, 3, 4, 5, 6, 7];
        var head = arrayToLinkedList(nodes);

        var result = middleNode(head);

        assert.equal(result.val, 4);
        assert.equal(result.toArray().toString(), [4, 5, 6, 7].toString());
    });
    it('Case 3: input [1,2,3,4,5,6] Assert: Node 4 from this list (Serialization: [4,5,6])', function () {
        var nodes = [1, 2, 3, 4, 5, 6];
        var head = arrayToLinkedList(nodes);

        var result = middleNode(head);

        assert.equal(result.val, 4);
        assert.equal(result.toArray().toString(), [4, 5, 6].toString());
    });
    it('Case 4: input [0,5,6,7,8,9] Assert: Node 4 from this list (Serialization: [7,8,9])', function () {
        var nodes = [0, 5, 6, 7, 8, 9];
        var head = arrayToLinkedList(nodes);

        var result = middleNode(head);

        assert.equal(result.val, 7);
        assert.equal(result.toArray().toString(), [7, 8, 9].toString());
    });
    it('Case 5: input [0] Assert: Node 4 from this list (Serialization: [0])', function () {
        var nodes = [0];
        var head = arrayToLinkedList(nodes);

        var result = middleNode(head);

        assert.equal(result.val, 0);
        assert.equal(result.toArray().toString(), [0].toString());
    });
});
