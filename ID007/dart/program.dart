import 'dart:io';

void main(List<String> args) {
  var a = stdin.readLineSync()?.split(" ").map(int.parse).toList() ?? [];
  var cnt = 0;
  for (var i = 1; i <= a[0]; i++) {
    if (i % a[1] == 0 || i % a[2] == 0) {
      cnt++;
    }
  }
  print(cnt);
}
