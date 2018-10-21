javascript: (function () {
  var url = location.href;
  if (url.indexOf("contest.atcoder.jp") === -1) {
    return false;
  }
  var oldhost = location.host;
  var contest = oldhost.split('.')[0];
  var betahost = `beta.atcoder.jp/contests/${contest}`;
  location.href = url.replace(oldhost, betahost);
})()
