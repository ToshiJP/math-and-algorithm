import 'dart:io';

void main(List<String> args) {
  var inputs = stdin.readLineSync()?.split(" ").map(int.parse).toList() ?? [];
  var n = inputs[0];
  var s = inputs[1];
  var ans = 0;
  for (var i = 1; i <= n; i++) {
    for (var j = 1; j <= n; j++) {
      if (i + j <= s) ans++;
    }
  }
  print(ans);
}
