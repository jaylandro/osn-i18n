import Vue from 'vue'
import App from './App.vue'
import i18n from './i18n'
import Eagle, { Options, CodeBlock } from 'eagle.js'
import hljs from 'highlight.js'

import 'eagle.js/dist/eagle.css'
import 'animate.css'

Vue.use(Eagle)
Vue.config.productionTip = false

Options.hljs = hljs

Eagle.use(CodeBlock)

new Vue({
  el: '#app',
  i18n,
  render: h => h(App)
})
