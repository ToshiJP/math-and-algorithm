import 'dart:io';

void main(List<String> args) {
  var n = int.parse(stdin.readLineSync() ?? "0");
  print(2 * n + 3);
}
