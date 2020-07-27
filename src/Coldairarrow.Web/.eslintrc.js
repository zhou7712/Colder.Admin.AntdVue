module.exports = {
  root: true,
  parserOptions: {
    parser: 'babel-eslint'
  },
  env: {
    browser: true,
  },
  extends: [
    'plugin:vue/essential',
    'standard'
  ],
  plugins: [
    'vue'
  ],
  // add your custom rules here 0-off 1-warn 2-error
  rules: {
    // allow async-await
    'generator-star-spacing': 'off',
    // allow debugger during development
    'no-debugger': process.env.NODE_ENV === 'production' ? 'error' : 'off',
    // 要求使用分号代替 ASI
    'semi': [2, 'always'],
    // 禁止不必要的分号
    'no-extra-semi': 2,
    // function的左括号之前可以不使用空格
    'space-before-function-paren': [0, 'always'],
    // 禁止 if 语句中 return 语句之后有 else 块
    'no-else-return': 2,
    // 禁止出现空函数
    'no-empty-function': 2,
    // 强制对多行注释使用特定风格
    'multiline-comment-style': 2,
    // 禁止在代码后使用内联注释
    /* 'no-inline-comments': 2, */
    // 禁止 if 作为唯一的语句出现在 else 语句中
    'no-lonely-if': 2,
    // 禁止连续赋值
    'no-multi-assign': 2,
    // 禁止在注释块中使用空白符、允许在空行使用空白符（空格、tab 和其它 Unicode 空白字符）
    'no-trailing-spaces': [2, {'skipBlankLines': true}],
    /* // 禁止对象{后，}前有空格
    'standard/object-curly-even-spacing': [2, 'never'],
    // 禁止数组[后，]前有空格
    'standard/array-bracket-even-spacing': [2, 'never'] */
    'no-throw-literal': [0]
  }
}
