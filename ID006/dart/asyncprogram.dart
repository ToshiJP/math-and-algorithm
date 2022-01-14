import 'dart:convert';
import 'dart:io';

Future<void> main(List<String> args) async {
  var n = int.parse(await stdin
      .transform(utf8.decoder)
      .transform(const LineSplitter())
      .first);
  print(2 * n + 3);
}
